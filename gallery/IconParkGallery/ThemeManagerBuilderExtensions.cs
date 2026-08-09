using AtomUI;
using AtomUI.Generated.IconParkGallery;
using IconParkGallery.Controls;

namespace IconParkGallery;

public static class ThemeManagerBuilderExtensions
{
    public static IAtomUIBuilder UseGalleryControls(this IAtomUIBuilder builder)
    {
        ArgumentNullException.ThrowIfNull(builder);
        GeneratedControlPackageRegistration.Register(
            builder.Theme,
            new GalleryControlThemesProvider());
        GeneratedLanguageModuleRegistration.Register(builder.Localization);
        return builder;
    }
}
