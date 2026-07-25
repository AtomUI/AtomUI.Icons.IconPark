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
using ScrollViewer = AtomUI.Desktop.Controls.ScrollViewer;

namespace IconParkGallery.Controls;

public class IconGallery : TemplatedControl, IMotionAwareControl
{
    private const double LoadMoreScrollThreshold = 240;

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
    
    private CompositeDisposable? _disposables;
    private ScrollViewer? _scrollViewer;
    private SearchEdit? _searchEdit;
    
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
        }
    }

    private void HandleIconInfoRepositoryChanged()
    {
        _disposables?.Dispose();
        if (IconInfoRepository != null)
        {
            _disposables = new CompositeDisposable();
            _disposables.Add(BindUtils.RelayBind(this, CategoryProperty, IconInfoRepository, IconMetaInfoRepository.CategoryProperty));
            _disposables.Add(BindUtils.RelayBind(this, IconThemeProperty, IconInfoRepository, IconMetaInfoRepository.IconThemeProperty));
            _disposables.Add(BindUtils.RelayBind(IconInfoRepository, IconMetaInfoRepository.ActivatedIconInfosProperty, this, IconInfosProperty));
            IconInfoRepository.RefreshIconInfos();
        }
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        if (_scrollViewer != null)
        {
            _scrollViewer.ScrollChanged -= HandleScrollChanged;
        }
        if (_searchEdit != null)
        {
            _searchEdit.SearchButtonClick -= HandleSearchButtonClick;
        }

        _scrollViewer = e.NameScope.Find<ScrollViewer>(IconGalleryThemeConstants.ScrollViewerPart);
        _searchEdit = e.NameScope.Find<SearchEdit>(IconGalleryThemeConstants.SearchInputPart);
        if (_scrollViewer != null)
        {
            _scrollViewer.ScrollChanged += HandleScrollChanged;
        }
        if (_searchEdit != null)
        {
            _searchEdit.SearchButtonClick += HandleSearchButtonClick;
        }
    }

    private void HandleScrollChanged(object? sender, ScrollChangedEventArgs e)
    {
        if (_scrollViewer == null || IconInfoRepository?.HasMoreIconInfos != true)
        {
            return;
        }

        var remainingHeight = _scrollViewer.Extent.Height - _scrollViewer.Viewport.Height - _scrollViewer.Offset.Y;
        if (remainingHeight <= LoadMoreScrollThreshold)
        {
            IconInfoRepository.LoadMoreIconInfos();
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
