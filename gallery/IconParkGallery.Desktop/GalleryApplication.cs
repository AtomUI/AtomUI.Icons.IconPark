using System.Globalization;
using AtomUI;
using AtomUI.Desktop.Controls;
using AtomUI.Localization;
using AtomUI.Theme;
using Avalonia.Controls.ApplicationLifetimes;
using IconParkGallery.Localization;

namespace IconParkGallery.Desktop;

public partial class GalleryApplication : BaseGalleryApplication
{
    public override void Initialize()
    {
        base.Initialize();
        this.UseAtomUI(builder =>
        {
            builder.UseLanguages(
                GalleryLanguageDefaults.Resolve(CultureInfo.CurrentUICulture),
                [LanguageTags.EnUS, LanguageTags.ZhCN, LanguageTags.ZhTW, LanguageTags.PtBR]);
            builder.WithInitialTheme(IThemeManager.DEFAULT_THEME_ID);
            builder.UseAlibabaSansFont();
            builder.UseDesktopControls();
            builder.UseGalleryControls();
        });
    }

    public GalleryApplication()
    {
        Name = "IconPark Icons Gallery";
    }
    
    public override void OnFrameworkInitializationCompleted()
    {
        switch (ApplicationLifetime)
        {
            case IClassicDesktopStyleApplicationLifetime desktop:
                desktop.MainWindow = CreateWorkspaceWindow();
                break;
        }

        base.OnFrameworkInitializationCompleted();
    }
}
