using AtomUI.Theme;
using AtomUI.Theme.Language;
using IconParkGallery.Controls;

namespace IconParkGallery;

public static class ThemeManagerBuilderExtensions
{
    public static IThemeManagerBuilder UseGalleryControls(this IThemeManagerBuilder themeManagerBuilder)
    {
        var controlTokenTypes = ControlTokenTypePool.GetTokenTypes();
        foreach (var controlType in controlTokenTypes)
        {
            themeManagerBuilder.AddControlToken(controlType.TokenType);
        }
        themeManagerBuilder.AddControlThemesProvider(new GalleryControlThemesProvider());
        var languageProviders = LanguageProviderPool.GetLanguageProviders();
        foreach (var languageProvider in languageProviders)
        {
            themeManagerBuilder.AddLanguageProviders(languageProvider);
        }
        return themeManagerBuilder;
    }
}
