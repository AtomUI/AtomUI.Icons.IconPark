using System.Reactive.Disposables;
using AtomUI.Controls;
using AtomUI.Data;
using AtomUI.Desktop.Controls;
using AtomUI.Icons.IconPark;
using AtomUI.Theme;
using AtomUI.Utils;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using IconParkGallery.Controls.Themes;
using IconParkGallery.Models;
using Control = Avalonia.Controls.Control;

namespace IconParkGallery.Controls;

public class IconGallery : TemplatedControl, IControlSharedTokenResourcesHost, IMotionAwareControl
{
    public static readonly StyledProperty<string?> CategoryProperty = 
        AvaloniaProperty.Register<IconGallery, string?>(nameof (Category));
    
    public static readonly StyledProperty<IconThemeType> IconThemeProperty = 
        AvaloniaProperty.Register<IconGallery, IconThemeType>(nameof (IconTheme));
    
    public static readonly StyledProperty<IEnumerable<IconMetaInfo>?> IconInfosProperty = 
        AvaloniaProperty.Register<IconGallery, IEnumerable<IconMetaInfo>?>(nameof (IconInfos));
    
    public static readonly StyledProperty<IconMetaInfoRepository?> IconInfoRepositoryProperty = 
        AvaloniaProperty.Register<IconGallery, IconMetaInfoRepository?>(nameof (IconInfoRepository));
    
    public static readonly StyledProperty<bool> IsMotionEnabledProperty =
        MotionAwareControlProperty.IsMotionEnabledProperty.AddOwner<IconGallery>();
    
    public string? Category
    {
        get => GetValue(CategoryProperty);
        set => SetValue(CategoryProperty, value);
    }
    
    public IconThemeType IconTheme
    {
        get => GetValue(IconThemeProperty);
        set => SetValue(IconThemeProperty, value);
    }

    public IEnumerable<IconMetaInfo>? IconInfos
    {
        get => GetValue(IconInfosProperty);
        set => SetValue(IconInfosProperty, value);
    }
    
    public IconMetaInfoRepository? IconInfoRepository
    {
        get => GetValue(IconInfoRepositoryProperty);
        set => SetValue(IconInfoRepositoryProperty, value);
    }
    
    public bool IsMotionEnabled
    {
        get => GetValue(IsMotionEnabledProperty);
        set => SetValue(IsMotionEnabledProperty, value);
    }
    
    #region 内部属性定义

    Control IControlSharedTokenResourcesHost.HostControl => this;
    string IControlSharedTokenResourcesHost.TokenId => IconGalleryToken.ID;
    Control IMotionAwareControl.PropertyBindTarget => this;
    #endregion
    
    private CompositeDisposable? _disposables;
    private CompositeDisposable? _iconThemedisposables;
    private ScrollViewer? _scrollViewer;
    private SearchEdit? _searchEdit;
    
    public IconGallery()
    {
        this.RegisterResources();
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == IconInfoRepositoryProperty)
        {
            HandleIconInfoRepositoryChanged();
        }
        else if (change.Property == IconInfosProperty)
        {
            if (_scrollViewer != null)
            {
                _scrollViewer.Offset = new Vector(0, 0);
            }

            HandleIconInfosChanged();
        }
    }

    private void HandleIconInfosChanged()
    {
        _iconThemedisposables?.Dispose();
        _iconThemedisposables = new CompositeDisposable();
        if (IconInfos != null)
        {
            foreach (var iconInfo in IconInfos)
            {
                if (iconInfo.Icon != null)
                {
                    _iconThemedisposables.Add(BindUtils.RelayBind(this, IconThemeProperty, iconInfo.Icon, Icon.IconThemeProperty));
                }
            }
        }
    }

    private void HandleIconInfoRepositoryChanged()
    {
        _disposables?.Dispose();
        if (IconInfoRepository != null)
        {
            _disposables = new CompositeDisposable();
            _disposables.Add(BindUtils.RelayBind(this, CategoryProperty, IconInfoRepository, IconMetaInfoRepository.CategoryProperty));
            _disposables.Add(BindUtils.RelayBind(IconInfoRepository, IconMetaInfoRepository.ActivatedIconInfosProperty, this, IconInfosProperty));
        }
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        _scrollViewer = e.NameScope.Find<ScrollViewer>(IconGalleryThemeConstants.ScrollViewerPart);
        _searchEdit = e.NameScope.Find<SearchEdit>(IconGalleryThemeConstants.SearchInputPart);
        if (_searchEdit != null)
        {
            _searchEdit.SearchButtonClick += HandleSearchButtonClick;
        }
    }

    private void HandleSearchButtonClick(object? sender, RoutedEventArgs e)
    {
        if (IconInfoRepository != null && _searchEdit != null)
        {
            var filter = _searchEdit.Text?.Trim();
            IconInfoRepository.Filter = filter;
        }
    }
}