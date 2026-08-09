using System.Collections;
using AtomUI;
using AtomUI.Controls;
using AtomUI.Controls.Primitives;
using AtomUI.Desktop.Controls;
using AtomUI.Localization;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using IconParkGallery.Controls.Themes;
using IconParkGallery.Localization;
using ComboBox = AtomUI.Desktop.Controls.ComboBox;
using ComboBoxItem = AtomUI.Desktop.Controls.ComboBoxItem;

namespace IconParkGallery.Controls;

public class Navigation : TemplatedControl
{
    private static readonly IReadOnlyDictionary<string, NavigationLangResourceKind> CategoryResourceKinds =
        new Dictionary<string, NavigationLangResourceKind>(StringComparer.Ordinal)
        {
            ["Abstract"]      = NavigationLangResourceKind.CategoryAbstract,
            ["Animals"]       = NavigationLangResourceKind.CategoryAnimals,
            ["Arrows"]        = NavigationLangResourceKind.CategoryArrows,
            ["Baby"]          = NavigationLangResourceKind.CategoryBaby,
            ["Base"]          = NavigationLangResourceKind.CategoryBase,
            ["Brand"]         = NavigationLangResourceKind.CategoryBrand,
            ["Build"]         = NavigationLangResourceKind.CategoryBuild,
            ["Character"]     = NavigationLangResourceKind.CategoryCharacter,
            ["Charts"]        = NavigationLangResourceKind.CategoryCharts,
            ["Clothes"]       = NavigationLangResourceKind.CategoryClothes,
            ["Communicate"]   = NavigationLangResourceKind.CategoryCommunicate,
            ["Components"]    = NavigationLangResourceKind.CategoryComponents,
            ["Connect"]       = NavigationLangResourceKind.CategoryConnect,
            ["Constellation"] = NavigationLangResourceKind.CategoryConstellation,
            ["Datas"]         = NavigationLangResourceKind.CategoryDatas,
            ["Edit"]          = NavigationLangResourceKind.CategoryEdit,
            ["Emoji"]         = NavigationLangResourceKind.CategoryEmoji,
            ["Energy"]        = NavigationLangResourceKind.CategoryEnergy,
            ["Foods"]         = NavigationLangResourceKind.CategoryFoods,
            ["Game"]          = NavigationLangResourceKind.CategoryGame,
            ["Graphics"]      = NavigationLangResourceKind.CategoryGraphics,
            ["Hands"]         = NavigationLangResourceKind.CategoryHands,
            ["Hardware"]      = NavigationLangResourceKind.CategoryHardware,
            ["Health"]        = NavigationLangResourceKind.CategoryHealth,
            ["Industry"]      = NavigationLangResourceKind.CategoryIndustry,
            ["Life"]          = NavigationLangResourceKind.CategoryLife,
            ["Makeups"]       = NavigationLangResourceKind.CategoryMakeups,
            ["Measurement"]   = NavigationLangResourceKind.CategoryMeasurement,
            ["Money"]         = NavigationLangResourceKind.CategoryMoney,
            ["Music"]         = NavigationLangResourceKind.CategoryMusic,
            ["Office"]        = NavigationLangResourceKind.CategoryOffice,
            ["Operate"]       = NavigationLangResourceKind.CategoryOperate,
            ["Others"]        = NavigationLangResourceKind.CategoryOthers,
            ["Peoples"]       = NavigationLangResourceKind.CategoryPeoples,
            ["Safe"]          = NavigationLangResourceKind.CategorySafe,
            ["Sports"]        = NavigationLangResourceKind.CategorySports,
            ["Time"]          = NavigationLangResourceKind.CategoryTime,
            ["Travel"]        = NavigationLangResourceKind.CategoryTravel,
            ["Weather"]       = NavigationLangResourceKind.CategoryWeather,
        };

    private readonly ILanguageManager? _languageManager;
    private readonly EventHandler<LanguageChangedEventArgs>? _languageChangedHandler;

    public Navigation()
    {
        _languageManager = Application.Current?.GetLanguageManager();
        if (_languageManager is not null)
        {
            _languageChangedHandler = HandleLanguageChanged;
            _languageManager.LanguageChanged += _languageChangedHandler;
        }
    }

    #region 公共属性定义

    public static readonly StyledProperty<List<string>?> CategoriesProperty = 
        AvaloniaProperty.Register<Navigation, List<string>?>(nameof (Categories));
    
    public static readonly StyledProperty<string?> CategoryProperty = 
        AvaloniaProperty.Register<Navigation, string?>(nameof (Category), "Abstract");
    
    public static readonly StyledProperty<IconThemeType> IconThemeProperty = 
        AvaloniaProperty.Register<Navigation, IconThemeType>(nameof (IconTheme));

    public List<string>? Categories
    {
        get => GetValue(CategoriesProperty);
        set => SetValue(CategoriesProperty, value);
    }
    
    public string? Category
    {
        get => GetValue(CategoryProperty);
        protected set => SetValue(CategoryProperty, value);
    }
    
    public IconThemeType IconTheme
    {
        get => GetValue(IconThemeProperty);
        protected set => SetValue(IconThemeProperty, value);
    }
    #endregion
    
    public event EventHandler<NavigateRequestEventArgs>? NavigateRequest;

    #region 内部属性定义

    public static readonly StyledProperty<IEnumerable?> CategoryMavMenuItemsProperty = 
        AvaloniaProperty.Register<Navigation, IEnumerable?>(nameof (CategoryMavMenuItems));

    public IEnumerable? CategoryMavMenuItems
    {
        get => GetValue(CategoryMavMenuItemsProperty);
        set => SetValue(CategoryMavMenuItemsProperty, value);
    }
    
    #endregion
    
    private ComboBox? _themeComboBox;
    private NavMenu? _categoryNavMenu;

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);
        if (change.Property == CategoriesProperty)
        {
            HandleCategoriesChanged();
        }
        else if (change.Property == IconThemeProperty ||
                 change.Property == CategoryProperty)
        {
            HandleCondChanged(Category, IconTheme);
        }
    }

    private void HandleCategoriesChanged()
    {
        if (Categories != null)
        {
            var selectedCategory = Category;
            if (string.IsNullOrEmpty(selectedCategory) ||
                !Categories.Contains(selectedCategory))
            {
                selectedCategory = Categories.FirstOrDefault();
            }

            var menuItems = new List<NavMenuNode>();
        
            foreach (var category in Categories)
            {
                menuItems.Add(new NavMenuNode
                {
                    Header = ResolveCategoryHeader(category),
                    ItemKey = category,
                });
            }
            SetCurrentValue(CategoryMavMenuItemsProperty, menuItems);
            if (!string.IsNullOrEmpty(selectedCategory) && _categoryNavMenu != null)
            {
                _categoryNavMenu.DefaultSelectedPath = new TreeNodePath(selectedCategory);
            }
        }
        else
        {
            SetCurrentValue(CategoryMavMenuItemsProperty, null);
        }
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        _categoryNavMenu = e.NameScope.Find<NavMenu>(NavigationThemeConstants.CategoryNavMenuPart);
        _themeComboBox = e.NameScope.Find<ComboBox>(NavigationThemeConstants.IconThemeComboBoxPart);
        if (_categoryNavMenu != null)
        {
            _categoryNavMenu.NavMenuNodeSelected += (sender, args) =>
            {
                var itemKey = args.NavMenuNode.ItemKey;
                if (itemKey.HasValue)
                {
                    SetCurrentValue(CategoryProperty, itemKey.Value.ToString());
                }
            };
            _categoryNavMenu.DefaultSelectedPath = new TreeNodePath("Abstract");
        }

        if (_themeComboBox != null)
        {
            _themeComboBox.SelectionChanged += (sender, args) =>
            {
                if (_themeComboBox.SelectedItem is ComboBoxItem item)
                {
                    SetCurrentValue(IconThemeProperty, (item.Tag as IconThemeType?)!);
                }
            };
            _themeComboBox.DropDownOpened += (sender, args) =>
            {
                if (_themeComboBox.SelectedItem is ComboBoxItem item)
                {
                    SetCurrentValue(IconThemeProperty, (item.Tag as IconThemeType?)!);
                }
            };
        }
    }

    protected override void OnDetachedFromVisualTree(VisualTreeAttachmentEventArgs e)
    {
        if (_languageManager is not null && _languageChangedHandler is not null)
        {
            _languageManager.LanguageChanged -= _languageChangedHandler;
        }

        base.OnDetachedFromVisualTree(e);
    }

    private void HandleCondChanged(string? category, IconThemeType iconTheme)
    {
        Dispatcher.Post(() => NavigateRequest?.Invoke(this, new NavigateRequestEventArgs(category, iconTheme)));
    }

    private void HandleLanguageChanged(object? sender, LanguageChangedEventArgs args)
    {
        HandleCategoriesChanged();
    }

    private static string ResolveCategoryHeader(string category)
    {
        if (CategoryResourceKinds.TryGetValue(category, out var resourceKind) &&
            Application.Current?.GetLocalizer() is { } localizer)
        {
            return localizer.Get(resourceKind);
        }

        return category;
    }
}
