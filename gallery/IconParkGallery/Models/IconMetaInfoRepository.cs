using AtomUI.Icons.IconPark;
using Avalonia;

namespace IconParkGallery.Models;

public partial class IconMetaInfoRepository : AvaloniaObject
{
    #region 公共属性定义

    public static readonly StyledProperty<string?> CategoryProperty = 
        AvaloniaProperty.Register<IconMetaInfoRepository, string?>(nameof (Category));
    
    public static readonly StyledProperty<IEnumerable<IconMetaInfo>?> ActivatedIconInfosProperty = 
        AvaloniaProperty.Register<IconMetaInfoRepository, IEnumerable<IconMetaInfo>?>(nameof (ActivatedIconInfos));
    
    public static readonly StyledProperty<string?> FilterProperty =
        AvaloniaProperty.Register<IconMetaInfoRepository, string?>(nameof (Filter));
    
    public string? Category
    {
        get => GetValue(CategoryProperty);
        set => SetValue(CategoryProperty, value);
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

    protected List<IconMetaInfo> IconInfos { get; set; } = new();
    public List<string> Categories { get; set; } = new();
    
    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == CategoryProperty ||
            change.Property == FilterProperty)
        {
            HandleCondChanged();
        }
    }

    private void HandleCondChanged()
    {
        var iconInfos = IconInfos.Where(FilterFn)
            .Select(info =>
            {
                info.Icon = info.Creator?.Invoke();
                return info;
            }).ToList();
        SetCurrentValue(ActivatedIconInfosProperty, iconInfos);
    }

    private bool FilterFn(IconMetaInfo info)
    {
        if (string.IsNullOrEmpty(Category) || info.Category == Category)
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
        }
        return false;
    }
}