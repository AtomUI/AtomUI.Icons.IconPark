using AtomUI.Controls;

namespace IconParkGallery.Controls;

public class NavigateRequestEventArgs : EventArgs
{
    public string? Category { get; }
    public IconThemeType IconTheme { get; }

    public NavigateRequestEventArgs(string? category, IconThemeType iconTheme)
    {
        Category = category;
        IconTheme = iconTheme;
    }
}