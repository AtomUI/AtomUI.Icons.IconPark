using System.Collections.Generic;
using AtomUI.Theme.Language;
using Avalonia.Controls;

namespace AtomUI.Theme.Language
{
    internal sealed class WorkspaceWindowEnUSLanguageProvider : LanguageProvider
    {
        public WorkspaceWindowEnUSLanguageProvider()
            : base(LanguageCode.en_US, "WorkspaceWindow")
        {
        }

        protected override System.Type GetResourceKindType()
        {
            return typeof(global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind);
        }

        public override void BuildResourceDictionary(IResourceDictionary dictionary)
        {
            var resourceKindType = GetResourceKindType();
            try
            {
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemCompactMode] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemCompactMode;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemDarkMode] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemDarkMode;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableFullScreen] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableFullScreen;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMaximize] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableMaximize;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMinimize] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableMinimize;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMotion] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableMotion;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMove] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableMove;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnablePin] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnablePin;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableResize] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableResize;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableWaveSpirit] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemEnableWaveSpirit;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemLanguage] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemLanguage;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemSettings] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemSettings;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemTheme] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemTheme;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemWindowOptions] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.en_US.MenuItemWindowOptions;
            }
            catch (System.Exception)
            {
                LogBuildResourceDictionaryError(resourceKindType);
                throw;
            }
        }
    }

    internal sealed class WorkspaceWindowZhCNLanguageProvider : LanguageProvider
    {
        public WorkspaceWindowZhCNLanguageProvider()
            : base(LanguageCode.zh_CN, "WorkspaceWindow")
        {
        }

        protected override System.Type GetResourceKindType()
        {
            return typeof(global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind);
        }

        public override void BuildResourceDictionary(IResourceDictionary dictionary)
        {
            var resourceKindType = GetResourceKindType();
            try
            {
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemCompactMode] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemCompactMode;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemDarkMode] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemDarkMode;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableFullScreen] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableFullScreen;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMaximize] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableMaximize;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMinimize] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableMinimize;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMotion] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableMotion;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableMove] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableMove;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnablePin] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnablePin;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableResize] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableResize;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemEnableWaveSpirit] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemEnableWaveSpirit;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemLanguage] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemLanguage;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemSettings] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemSettings;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemTheme] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemTheme;
                dictionary[global::IconParkGallery.Localization.WorkspaceWindowLangResourceKind.MenuItemWindowOptions] = global::IconParkGallery.Workspace.Localization.WorkspaceWindowLang.zh_CN.MenuItemWindowOptions;
            }
            catch (System.Exception)
            {
                LogBuildResourceDictionaryError(resourceKindType);
                throw;
            }
        }
    }

    internal class LanguageProviderPool
    {
        internal static IList<LanguageProvider> GetLanguageProviders()
        {
            List<LanguageProvider> languageProviders = new List<LanguageProvider>(2);
            languageProviders.Add(new WorkspaceWindowEnUSLanguageProvider());
            languageProviders.Add(new WorkspaceWindowZhCNLanguageProvider());
            return languageProviders;
        }
    }
}
