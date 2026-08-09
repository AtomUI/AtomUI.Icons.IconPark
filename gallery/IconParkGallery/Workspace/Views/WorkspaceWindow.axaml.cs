using System.Reactive;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using AtomUI.Controls;
using AtomUI.Desktop.Controls;
using AtomUI.Theme;
using IconParkGallery.Workspace.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input.Platform;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Media;
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
    ThemeCatalog,
    LightMode,
    DarkMode,
    FollowSystem,
    Compact,
    Motion,
    WaveSpirit,
    LanguageZhCN,
    LanguageZhTW,
    LanguageEnUS,
    LanguagePtBR,
}

public partial class WorkspaceWindow : ReactiveWindow<WorkspaceWindowViewModel>
{
    public const string LanguageId = nameof(WorkspaceWindow);
    private const string ThemeColorGroupName = "ThemeColor";

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
    private readonly List<MenuItem> _themeMenuItems = new();
    private PropertyChangedEventHandler? _viewModelPropertyChangedHandler;
    
    public WorkspaceWindow()
    {
        ViewModel = new WorkspaceWindowViewModel();
        InitializeComponent();
        ConfigureThemeMenu();
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

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        if (_isMenuHandlerRegistered)
        {
            RemoveHandler(MenuItem.ClickEvent, HandleMenuItemClick);
            _isMenuHandlerRegistered = false;
        }

        if (ViewModel is not null && _viewModelPropertyChangedHandler is not null)
        {
            ViewModel.PropertyChanged -= _viewModelPropertyChangedHandler;
            _viewModelPropertyChangedHandler = null;
        }

        ViewModel?.Dispose();
        base.OnDetachedFromVisualTree(e);
    }

    private void ConfigureThemeMenu()
    {
        if (ViewModel is null)
        {
            return;
        }

        RebuildThemeMenuItems();
        _viewModelPropertyChangedHandler = HandleViewModelPropertyChanged;
        ViewModel.PropertyChanged += _viewModelPropertyChangedHandler;
    }

    private void HandleViewModelPropertyChanged(object? sender, PropertyChangedEventArgs args)
    {
        if (args.PropertyName is nameof(WorkspaceWindowViewModel.AvailableThemes) or
            nameof(WorkspaceWindowViewModel.CurrentThemeId))
        {
            RebuildThemeMenuItems();
        }
    }

    private void RebuildThemeMenuItems()
    {
        if (ViewModel is null)
        {
            return;
        }

        foreach (var existing in _themeMenuItems)
        {
            ThemeCatalogMenuItem.Items.Remove(existing);
        }
        _themeMenuItems.Clear();

        var insertIndex = 0;
        var switchThemeCommand = new StableCommand(ViewModel.SwitchThemeCommand);
        foreach (var theme in ViewModel.AvailableThemes)
        {
            var item = new MenuItem
            {
                Header           = CreateThemeMenuHeader(theme),
                ToggleType       = MenuItemToggleType.Radio,
                GroupName        = ThemeColorGroupName,
                IsChecked        = string.Equals(theme.Id, ViewModel.CurrentThemeId, StringComparison.Ordinal),
                Command          = switchThemeCommand,
                CommandParameter = theme.Id
            };
            ThemeCatalogMenuItem.Items.Insert(insertIndex++, item);
            _themeMenuItems.Add(item);
        }
    }

    private static Control CreateThemeMenuHeader(ThemeInfo theme)
    {
        var header = new Grid
        {
            Width             = 160,
            ColumnDefinitions = new ColumnDefinitions("*,Auto")
        };
        header.Children.Add(new Avalonia.Controls.TextBlock
        {
            Text              = theme.Name,
            VerticalAlignment = VerticalAlignment.Center
        });

        if (theme.AccentColor is { } accentColor)
        {
            var swatch = new Border
            {
                Width               = 12,
                Height              = 12,
                CornerRadius        = new CornerRadius(2),
                Background          = new SolidColorBrush(accentColor),
                Margin              = new Thickness(12, 0, 0, 0),
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment   = VerticalAlignment.Center,
                IsHitTestVisible    = false
            };
            Grid.SetColumn(swatch, 1);
            header.Children.Add(swatch);
        }

        return header;
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
                case WindowMenuItemKind.LightMode:
                    ViewModel.SetAppearanceModeCommand.Execute(ThemePreference.Light)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.DarkMode:
                    ViewModel.SetAppearanceModeCommand.Execute(ThemePreference.Dark)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.FollowSystem:
                    ViewModel.SetAppearanceModeCommand.Execute(ThemePreference.System)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.Compact:
                    ViewModel.ToggleCompactModeCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.Motion:
                    if (!menuItem.IsChecked &&
                        FindSiblingMenuItem(menuItem, WindowMenuItemKind.WaveSpirit) is { } waveSpiritMenuItem)
                    {
                        waveSpiritMenuItem.IsChecked = false;
                    }
                    ViewModel.ToggleMotionCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.WaveSpirit:
                    if (menuItem.IsChecked &&
                        FindSiblingMenuItem(menuItem, WindowMenuItemKind.Motion) is { } motionMenuItem)
                    {
                        motionMenuItem.IsChecked = true;
                    }
                    ViewModel.ToggleWaveSpiritCommand.Execute(menuItem.IsChecked)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.LanguageZhCN:
                    ViewModel.SwitchToZhCNCommand.Execute(Unit.Default)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.LanguageZhTW:
                    ViewModel.SwitchToZhTWCommand.Execute(Unit.Default)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.LanguageEnUS:
                    ViewModel.SwitchToEnUSCommand.Execute(Unit.Default)
                             .Subscribe();
                    break;
                case WindowMenuItemKind.LanguagePtBR:
                    ViewModel.SwitchToPtBRCommand.Execute(Unit.Default)
                             .Subscribe();
                    break;
            }
        }
    }

    private static MenuItem? FindSiblingMenuItem(MenuItem menuItem, WindowMenuItemKind kind)
    {
        if (menuItem.Parent is not MenuItem parent)
        {
            return null;
        }

        foreach (var item in parent.Items)
        {
            if (item is MenuItem sibling &&
                sibling.Tag is WindowMenuItemKind siblingKind &&
                siblingKind == kind)
            {
                return sibling;
            }
        }

        return null;
    }

    private sealed class StableCommand(ICommand innerCommand) : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { }
            remove { }
        }

        public bool CanExecute(object? parameter)
        {
            return innerCommand.CanExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            if (innerCommand.CanExecute(parameter))
            {
                innerCommand.Execute(parameter);
            }
        }
    }
}
