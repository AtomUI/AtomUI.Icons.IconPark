using AtomUI.Theme;
using AtomUI.Theme.DesignTokens;
using IconParkGallery.Controls.DesignTokens;

namespace IconParkGallery.Controls;

[ControlDesignToken]
internal class NavigationToken : AbstractControlDesignToken
{
    public const string ID = "Navigation";
    
    /// <summary>
    /// 默认宽度
    /// </summary>
    public double PanelWidth { get; set; }

    public NavigationToken()
        : base(ID)
    {
    }
    
    public override void CalculateTokenValues(bool isDarkMode)
    {
        base.CalculateTokenValues(isDarkMode);
        PanelWidth = 200;
    }
}
