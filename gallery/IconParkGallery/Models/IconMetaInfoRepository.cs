using AtomUI.Controls;
using AtomUI.Icons.IconPark;
using Avalonia;
using Avalonia.Collections;

namespace IconParkGallery.Models;

public partial class IconMetaInfoRepository : AvaloniaObject
{
    private const int InitialIconLoadCount     = 96;
    private const int IncrementalIconLoadCount = 96;

    #region 公共属性定义

    public static readonly StyledProperty<string?> CategoryProperty = 
        AvaloniaProperty.Register<IconMetaInfoRepository, string?>(nameof (Category), "Abstract");
    
    public static readonly StyledProperty<IconThemeType> IconThemeProperty = 
        AvaloniaProperty.Register<IconMetaInfoRepository, IconThemeType>(nameof (IconTheme));
    
    public static readonly StyledProperty<IEnumerable<IconMetaInfo>?> ActivatedIconInfosProperty = 
        AvaloniaProperty.Register<IconMetaInfoRepository, IEnumerable<IconMetaInfo>?>(nameof (ActivatedIconInfos));
    
    public static readonly StyledProperty<string?> FilterProperty =
        AvaloniaProperty.Register<IconMetaInfoRepository, string?>(nameof (Filter));
    
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
    
    public IEnumerable<IconMetaInfo>? ActivatedIconInfos
    {
        get => GetValue(ActivatedIconInfosProperty);
        set => SetValue(ActivatedIconInfosProperty, value);
    }
    
    public string? Filter
    {
        get => GetValue(FilterProperty);
        set => SetValue(FilterProperty, value);
    }
    
    #endregion

    public List<string> Categories { get; set; } = new();

    private List<IconMetaInfo> _matchedIconInfos = new();
    private AvaloniaList<IconMetaInfo> _activatedIconInfos = new();
    private int _loadedIconCount;

    public bool HasMoreIconInfos => _loadedIconCount < _matchedIconInfos.Count;

    public void RefreshIconInfos()
    {
        HandleCondChanged();
    }
    
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == CategoryProperty ||
            change.Property == IconThemeProperty ||
            change.Property == FilterProperty)
        {
            HandleCondChanged();
        }
    }

    private void HandleCondChanged()
    {
        ResetActivatedIconInfos();

        _matchedIconInfos = CreateIconInfos(Category, IconTheme);
        if (!string.IsNullOrEmpty(Filter))
        {
            _matchedIconInfos = _matchedIconInfos
                .Where(FilterFn)
                .ToList();
        }

        LoadMoreIconInfos(InitialIconLoadCount);
    }

    private bool FilterFn(IconMetaInfo info)
    {
        if (string.IsNullOrEmpty(Filter))
        {
            return true;
        }

        if (info.Name.Contains(Filter, StringComparison.InvariantCultureIgnoreCase))
        {
            return true;
        }

        foreach (var tag in info.Tags)
        {
            if (tag.Contains(Filter, StringComparison.InvariantCultureIgnoreCase))
            {
                return true;
            }
        }

        return false;
    }

    public void LoadMoreIconInfos()
    {
        LoadMoreIconInfos(IncrementalIconLoadCount);
    }

    private void LoadMoreIconInfos(int count)
    {
        if (!HasMoreIconInfos)
        {
            return;
        }

        var targetCount = Math.Min(_loadedIconCount + count, _matchedIconInfos.Count);
        for (var i = _loadedIconCount; i < targetCount; i++)
        {
            var iconInfo = _matchedIconInfos[i];
            iconInfo.Icon = iconInfo.Creator?.Invoke();
            _activatedIconInfos.Add(iconInfo);
        }

        _loadedIconCount = targetCount;
    }

    private void ResetActivatedIconInfos()
    {
        foreach (var iconInfo in _activatedIconInfos)
        {
            iconInfo.Icon = null;
        }

        _loadedIconCount    = 0;
        _activatedIconInfos = new AvaloniaList<IconMetaInfo>();
        SetCurrentValue(ActivatedIconInfosProperty, _activatedIconInfos);
    }

    protected partial List<IconMetaInfo> CreateIconInfos(string? category, IconThemeType iconTheme);
}
