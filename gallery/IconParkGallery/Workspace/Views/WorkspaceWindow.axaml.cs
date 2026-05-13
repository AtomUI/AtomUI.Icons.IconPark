using System.Reactive;
using System.Diagnostics;
using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using IconParkGallery.Workspace.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;
using Avalonia.Threading;
using IconParkGallery.Controls;
using IconParkGallery.Models;
using ReactiveUI;
using MenuItem = AtomUI.Desktop.Controls.MenuItem;

namespace IconParkGallery.Workspace.Views;

internal enum WindowMenuItemKind 
{
    FullScreen,
    Pin,
    Minimize,
    Maximize,
    Move,
    Resize,
    DarkMode,
    Compact,
    Motion,
    WaveSpirit,
    LanguageZhCN,
    LanguageEnUS,
}

public partial class WorkspaceWindow : ReactiveWindow<WorkspaceWindowViewModel>
{
    public const string LanguageId = nameof(WorkspaceWindow);

    static WorkspaceWindow()
    {
        IconInfoItem.ClickedEvent.AddClassHandler<WorkspaceWindow>((window, args) =>
        {
            if (args.Source is IconInfoItem iconInfoItem)
            {
                window.HandleIconItemClicked(iconInfoItem);
            }
        });
    }
    
    private WindowMessageManager? _messageManager;
    private bool _isMenuHandlerRegistered;
    private bool _isRepositoryInitializationRequested;
    
    public WorkspaceWindow()
    {
        ViewModel = new WorkspaceWindowViewModel();
        InitializeComponent();
        _messageManager = new WindowMessageManager(this);
    }

    private async void HandleIconItemClicked(IconInfoItem infoItem)
    {
        _messageManager?.Show(
            new Message(
                type: MessageType.Success,
            content:$"<{infoItem.IconName} /> copied 🎉"
        ));
        var clipboard = TopLevel.GetTopLevel(this)?.Clipboard;
        if (clipboard != null)
        {
            await clipboard.SetTextAsync(infoItem.IconName);
        }
    }

    private void InitializeIconsInfos(WorkspaceWindowViewModel model)
    {
        Debug.Assert(model.IconInfoRepository != null);
        model.Categories = model.IconInfoRepository.Categories;
    }
    
    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        if (!_isMenuHandlerRegistered)
        {
            AddHandler(MenuItem.ClickEvent, HandleMenuItemClick);
            _isMenuHandlerRegistered = true;
        }

        if (!_isRepositoryInitializationRequested)
        {
            _isRepositoryInitializationRequested = true;
            Dispatcher.InvokeAsync(InitializeIconRepository, DispatcherPriority.Background);
        }
    }

    private void InitializeIconRepository()
    {
        if (ViewModel is { IconInfoRepository: null } viewModel)
        {
            viewModel.IconInfoRepository = new IconMetaInfoRepository();
            InitializeIconsInfos(viewModel);
        }
    }
    
    private void HandleMenuItemClick(object? sender, RoutedEventArgs e)
    {
        if (ViewModel is null) return;

        if (e.Source is MenuItem menuItem && menuItem.Tag is WindowMenuItemKind kind)
        {
            if (menuItem.ToggleType == MenuItemToggleType.None) return;
            
            switch (kind)
            {
                case WindowMenuItemKind.FullScreen:
                    IsFullScreenCaptionButtonVisible = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Pin:
                    IsPinCaptionButtonVisible = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Minimize:
                    CanMinimize = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Maximize:
                    CanMaximize = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Move:
                    IsMoveEnabled = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.Resize:
                    CanResize = menuItem.IsChecked;
                    break;
                case WindowMenuItemKind.DarkMode:
                    ViewModel.ToggleDarkModeCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.Compact:
                    ViewModel.ToggleCompactModeCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.Motion:
                    if (menuItem.Parent is MenuItem themeMenuItem)
                    {
                        foreach (var item in themeMenuItem.Items)
                        {
                            if (item is MenuItem themeMenuChildItem &&
                                themeMenuChildItem.Tag is WindowMenuItemKind childKind &&
                                childKind == WindowMenuItemKind.WaveSpirit)
                            {
                                if (!menuItem.IsChecked)
                                {
                                    themeMenuChildItem.IsChecked = false;
                                }
                            }
                        }
                    }
                    ViewModel.ToggleMotionCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.WaveSpirit:
                    ViewModel.ToggleWaveSpiritCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.LanguageZhCN:
                    ViewModel.SwitchToZhCNCommand.Execute(Unit.Default)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.LanguageEnUS:
                    ViewModel.SwitchToEnUSCommand.Execute(Unit.Default)
                             .Subscribe();
                    break;
            }
        }
    }
}
