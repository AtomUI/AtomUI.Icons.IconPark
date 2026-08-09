using System.Reactive;
using System.Diagnostics;
using AtomUI;
using AtomUI.Controls;
using AtomUI.Localization;
using AtomUI.Theme;
using AtomUI.Theme.Algorithms;
using AtomUI.Theme.Configuration;
using AtomUI.Theme.Resources;
using Avalonia;
using Avalonia.Platform;
using Avalonia.Styling;
using IconParkGallery.Models;
using ReactiveUI;

namespace IconParkGallery.Workspace.ViewModels;

public class WorkspaceWindowViewModel : ReactiveObject, IScreen, IDisposable
{
    private readonly IThemeManager? _themeManager;
    private readonly ILanguageManager? _languageManager;
    private readonly EventHandler<LanguageChangedEventArgs>? _languageChangedHandler;
    private readonly EventHandler<ThemeChangedEventArgs>? _themeChangedHandler;
    private readonly EventHandler<ThemeCatalogChangedEventArgs>? _themeCatalogChangedHandler;
    private IDisposable? _systemAppearanceSubscription;
    private bool _isDisposed;
    private bool _hasExplicitAppearanceMode;
    private bool _isDark;
    private bool _isCompact;
    private bool _isMotionEnabled = true;
    private bool _isWaveSpiritEnabled = true;
    private ThemeAlgorithm[] _baseAlgorithms = [ThemeAlgorithm.Default];
    private IReadOnlyList<ThemeInfo> _availableThemes = Array.Empty<ThemeInfo>();
    private string _currentThemeId = IThemeManager.DEFAULT_THEME_ID;
    private ThemePreference _appearanceMode = ThemePreference.Light;

    public RoutingState Router { get; } = new RoutingState();
    
    private List<string>? _categories;

    public List<string>? Categories
    {
        get => _categories;
        set => this.RaiseAndSetIfChanged(ref _categories, value);
    }
    
    private IconMetaInfoRepository? _iconInfoRepository;

    public IconMetaInfoRepository? IconInfoRepository
    {
        get => _iconInfoRepository;
        set => this.RaiseAndSetIfChanged(ref _iconInfoRepository, value);
    }

    public ReactiveCommand<bool, Unit> ToggleDarkModeCommand { get; }
    public ReactiveCommand<ThemePreference, Unit> SetAppearanceModeCommand { get; }
    public ReactiveCommand<bool, Unit> ToggleCompactModeCommand { get; }
    public ReactiveCommand<bool, Unit> ToggleMotionCommand      { get; }
    public ReactiveCommand<bool, Unit> ToggleWaveSpiritCommand  { get; }
    public ReactiveCommand<string, Unit> SwitchThemeCommand     { get; }
    public ReactiveCommand<Unit, Unit> SwitchToZhCNCommand      { get; }
    public ReactiveCommand<Unit, Unit> SwitchToZhTWCommand      { get; }
    public ReactiveCommand<Unit, Unit> SwitchToEnUSCommand      { get; }
    public ReactiveCommand<Unit, Unit> SwitchToPtBRCommand      { get; }

    public ThemePreference AppearanceMode
    {
        get => _appearanceMode;
        private set => SetAppearanceModeState(value);
    }

    public bool IsLightAppearanceMode => AppearanceMode == ThemePreference.Light;

    public bool IsDarkAppearanceMode => AppearanceMode == ThemePreference.Dark;

    public bool IsSystemAppearanceMode => AppearanceMode == ThemePreference.System;

    public IReadOnlyList<ThemeInfo> AvailableThemes
    {
        get => _availableThemes;
        private set => this.RaiseAndSetIfChanged(ref _availableThemes, value);
    }

    public string CurrentThemeId
    {
        get => _currentThemeId;
        private set => this.RaiseAndSetIfChanged(ref _currentThemeId, value);
    }

    private bool _isZhCN;
    public bool IsZhCN
    {
        get => _isZhCN;
        private set => this.RaiseAndSetIfChanged(ref _isZhCN, value);
    }

    private bool _isZhTW;
    public bool IsZhTW
    {
        get => _isZhTW;
        private set => this.RaiseAndSetIfChanged(ref _isZhTW, value);
    }

    private bool _isEnUS;
    public bool IsEnUS
    {
        get => _isEnUS;
        private set => this.RaiseAndSetIfChanged(ref _isEnUS, value);
    }

    private bool _isPtBR;
    public bool IsPtBR
    {
        get => _isPtBR;
        private set => this.RaiseAndSetIfChanged(ref _isPtBR, value);
    }
    
    public WorkspaceWindowViewModel()
    {
        _themeManager = Application.Current?.GetThemeManager();
        _languageManager = Application.Current?.GetLanguageManager();

        AvailableThemes = CaptureThemes(_themeManager?.AvailableThemes);
        SyncThemeState(_themeManager?.CurrentTheme, null);

        ToggleDarkModeCommand = ReactiveCommand.CreateFromTask<bool>(SetDarkModeAsync);
        SetAppearanceModeCommand = ReactiveCommand.CreateFromTask<ThemePreference>(SetAppearanceModeAsync);
        ToggleCompactModeCommand = ReactiveCommand.CreateFromTask<bool>(SetCompactModeAsync);
        ToggleMotionCommand = ReactiveCommand.CreateFromTask<bool>(SetMotionEnabledAsync);
        ToggleWaveSpiritCommand = ReactiveCommand.CreateFromTask<bool>(SetWaveSpiritEnabledAsync);
        SwitchThemeCommand = ReactiveCommand.CreateFromTask<string>(SwitchThemeAsync);

        SwitchToZhCNCommand = ReactiveCommand.Create(() => SetLanguage(LanguageTags.ZhCN));
        SwitchToZhTWCommand = ReactiveCommand.Create(() => SetLanguage(LanguageTags.ZhTW));
        SwitchToEnUSCommand = ReactiveCommand.Create(() => SetLanguage(LanguageTags.EnUS));
        SwitchToPtBRCommand = ReactiveCommand.Create(() => SetLanguage(LanguageTags.PtBR));

        SyncLanguageState(_languageManager?.Current);
        if (_themeManager != null)
        {
            _themeChangedHandler = HandleThemeChanged;
            _themeCatalogChangedHandler = HandleThemeCatalogChanged;
            _themeManager.ThemeChanged += _themeChangedHandler;
            _themeManager.ThemeCatalogChanged += _themeCatalogChangedHandler;
        }
        if (_languageManager != null)
        {
            _languageChangedHandler = HandleLanguageChanged;
            _languageManager.LanguageChanged += _languageChangedHandler;
        }
    }

    public void Dispose()
    {
        if (_isDisposed)
        {
            return;
        }

        _isDisposed = true;
        ReleaseSystemAppearanceSubscription();
        if (_languageManager is not null && _languageChangedHandler is not null)
        {
            _languageManager.LanguageChanged -= _languageChangedHandler;
        }
        if (_themeManager is not null && _themeChangedHandler is not null)
        {
            _themeManager.ThemeChanged -= _themeChangedHandler;
        }
        if (_themeManager is not null && _themeCatalogChangedHandler is not null)
        {
            _themeManager.ThemeCatalogChanged -= _themeCatalogChangedHandler;
        }
    }

    private async Task SetDarkModeAsync(bool isDark)
    {
        await SetAppearanceModeAsync(
            isDark
                ? ThemePreference.Dark
                : ThemePreference.Light);
    }

    private async Task SetAppearanceModeAsync(ThemePreference appearanceMode)
    {
        ValidateAppearanceMode(appearanceMode);

        _hasExplicitAppearanceMode = true;
        AppearanceMode             = appearanceMode;
        if (appearanceMode == ThemePreference.System)
        {
            SubscribeSystemAppearance();
            _isDark = GetCurrentSystemAppearance() == ThemeAppearance.Dark;
            await ApplyThemeSettingsAsync(reason: ThemeTransitionReason.FollowSystem);
            return;
        }

        ReleaseSystemAppearanceSubscription();
        _isDark = appearanceMode == ThemePreference.Dark;
        await ApplyThemeSettingsAsync();
    }

    private async Task SetCompactModeAsync(bool isCompact)
    {
        _isCompact = isCompact;
        await ApplyThemeSettingsAsync();
    }

    private async Task SetMotionEnabledAsync(bool enabled)
    {
        _isMotionEnabled = enabled;
        if (!enabled)
        {
            _isWaveSpiritEnabled = false;
        }
        await ApplyThemeSettingsAsync();
    }

    private async Task SetWaveSpiritEnabledAsync(bool enabled)
    {
        if (enabled)
        {
            _isMotionEnabled = true;
        }
        _isWaveSpiritEnabled = enabled;
        await ApplyThemeSettingsAsync();
    }

    private Task SwitchThemeAsync(string themeId)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(themeId);
        if (string.Equals(themeId, CurrentThemeId, StringComparison.Ordinal))
        {
            return Task.CompletedTask;
        }

        return ApplyThemeSettingsAsync(themeId);
    }

    private async Task ApplyThemeSettingsAsync(string? requestedThemeId = null,
                                               ThemeTransitionReason reason = ThemeTransitionReason.UserRequest)
    {
        if (_themeManager is null)
        {
            return;
        }

        var algorithms = new List<ThemeAlgorithm>(_baseAlgorithms.Length + 2);
        algorithms.AddRange(_baseAlgorithms);
        if (_isCompact)
        {
            algorithms.Add(ThemeAlgorithm.Compact);
        }
        if (_isDark)
        {
            algorithms.Add(ThemeAlgorithm.Dark);
        }

        var config = new ThemeConfigBuilder()
                     .WithAlgorithms(algorithms.ToArray())
                     .WithToken(nameof(SharedTokenKind.EnableMotion), _isMotionEnabled ? "true" : "false")
                     .WithToken(nameof(SharedTokenKind.EnableWaveSpirit), _isWaveSpiritEnabled ? "true" : "false")
                     .Build();
        var result = await _themeManager.ApplyThemeAsync(
            new ThemeRequest(
                requestedThemeId ??
                _themeManager.CurrentTheme?.ThemeId ??
                IThemeManager.DEFAULT_THEME_ID,
                config,
                reason));
        if (result.Status == ThemeTransitionStatus.Failed)
        {
            this.RaisePropertyChanged(nameof(CurrentThemeId));
            var message = string.Join(" ", result.Diagnostics.Select(static diagnostic => diagnostic.Message));
            throw new ThemeLoadException(message, result.Exception);
        }
        if (result.Status == ThemeTransitionStatus.Superseded)
        {
            this.RaisePropertyChanged(nameof(CurrentThemeId));
        }
    }

    private void SubscribeSystemAppearance()
    {
        ReleaseSystemAppearanceSubscription();
        if (Application.Current?.PlatformSettings is not { } settings)
        {
            return;
        }

        void HandleColorValuesChanged(object? sender, PlatformColorValues values)
        {
            HandleSystemAppearanceChanged(ToThemeAppearance(values.ThemeVariant));
        }

        settings.ColorValuesChanged += HandleColorValuesChanged;
        _systemAppearanceSubscription = new DisposableAction(
            () => settings.ColorValuesChanged -= HandleColorValuesChanged);
    }

    private void ReleaseSystemAppearanceSubscription()
    {
        _systemAppearanceSubscription?.Dispose();
        _systemAppearanceSubscription = null;
    }

    private async void HandleSystemAppearanceChanged(ThemeAppearance appearance)
    {
        if (_isDisposed || AppearanceMode != ThemePreference.System)
        {
            return;
        }

        var isDark = appearance == ThemeAppearance.Dark;
        if (_isDark == isDark)
        {
            return;
        }

        _isDark = isDark;
        try
        {
            await ApplyThemeSettingsAsync(reason: ThemeTransitionReason.FollowSystem).ConfigureAwait(true);
        }
        catch (Exception exception)
        {
            Debug.WriteLine(exception);
        }
    }

    private void SetLanguage(LanguageTag language)
    {
        if (_languageManager is not null)
        {
            _languageManager.ChangeLanguage(language);
        }
    }

    private void HandleLanguageChanged(object? sender, LanguageChangedEventArgs args)
    {
        if (!_isDisposed)
        {
            SyncLanguageState(args.Result.NewState);
        }
    }

    private void SyncLanguageState(LanguageState? state)
    {
        IsZhCN = state?.CurrentLanguage == LanguageTags.ZhCN;
        IsZhTW = state?.CurrentLanguage == LanguageTags.ZhTW;
        IsEnUS = state?.CurrentLanguage == LanguageTags.EnUS;
        IsPtBR = state?.CurrentLanguage == LanguageTags.PtBR;
    }

    private void HandleThemeChanged(object? sender, ThemeChangedEventArgs args)
    {
        if (!_isDisposed)
        {
            SyncThemeState(args.State, args.Request.Config);
        }
    }

    private void HandleThemeCatalogChanged(object? sender, ThemeCatalogChangedEventArgs args)
    {
        if (_isDisposed)
        {
            return;
        }

        AvailableThemes = CaptureThemes(args.AvailableThemes);
        if (args.CurrentTheme is not null)
        {
            CurrentThemeId = args.CurrentTheme.ThemeId;
        }
    }

    private void SyncThemeState(ThemeState? state, ThemeConfig? config)
    {
        if (state is not null)
        {
            CurrentThemeId = state.ThemeId;
            _isDark = state.Appearance == ThemeAppearance.Dark;
            if (!_hasExplicitAppearanceMode)
            {
                AppearanceMode = _isDark
                    ? ThemePreference.Dark
                    : ThemePreference.Light;
            }
            _isCompact = state.Algorithms.Contains(ThemeAlgorithm.Compact);
            _baseAlgorithms = state.Algorithms
                                   .Where(static algorithm =>
                                       algorithm is not ThemeAlgorithm.Compact and not ThemeAlgorithm.Dark)
                                   .ToArray();
            if (_baseAlgorithms.Length == 0)
            {
                _baseAlgorithms = [ThemeAlgorithm.Default];
            }
        }

        _isMotionEnabled = ReadBooleanToken(config, nameof(SharedTokenKind.EnableMotion), true);
        _isWaveSpiritEnabled = _isMotionEnabled &&
                               ReadBooleanToken(config, nameof(SharedTokenKind.EnableWaveSpirit), true);
    }

    private static IReadOnlyList<ThemeInfo> CaptureThemes(IReadOnlyList<ThemeInfo>? themes)
    {
        return themes is null
            ? Array.Empty<ThemeInfo>()
            : Array.AsReadOnly(themes.ToArray());
    }

    private void SetAppearanceModeState(ThemePreference appearanceMode)
    {
        if (_appearanceMode == appearanceMode)
        {
            return;
        }

        _appearanceMode = appearanceMode;
        this.RaisePropertyChanged(nameof(AppearanceMode));
        this.RaisePropertyChanged(nameof(IsLightAppearanceMode));
        this.RaisePropertyChanged(nameof(IsDarkAppearanceMode));
        this.RaisePropertyChanged(nameof(IsSystemAppearanceMode));
    }

    private static ThemeAppearance GetCurrentSystemAppearance()
    {
        var application = Application.Current;
        if (application?.PlatformSettings is { } settings)
        {
            return ToThemeAppearance(settings.GetColorValues().ThemeVariant);
        }

        return application?.ActualThemeVariant == ThemeVariant.Dark
            ? ThemeAppearance.Dark
            : ThemeAppearance.Light;
    }

    private static ThemeAppearance ToThemeAppearance(PlatformThemeVariant platformTheme)
    {
        return platformTheme == PlatformThemeVariant.Dark
            ? ThemeAppearance.Dark
            : ThemeAppearance.Light;
    }

    private static bool ReadBooleanToken(ThemeConfig? config, string name, bool defaultValue)
    {
        return config is not null &&
               config.Tokens.TryGetValue(name, out var value) &&
               bool.TryParse(value, out var parsed)
            ? parsed
            : defaultValue;
    }

    private static void ValidateAppearanceMode(ThemePreference appearanceMode)
    {
        if (appearanceMode is not ThemePreference.Light and
            not ThemePreference.Dark and
            not ThemePreference.System)
        {
            throw new ArgumentOutOfRangeException(
                nameof(appearanceMode),
                appearanceMode,
                "Unsupported gallery theme appearance mode.");
        }
    }

    private sealed class DisposableAction : IDisposable
    {
        private readonly Action _action;
        private bool _isDisposed;

        public DisposableAction(Action action)
        {
            _action = action;
        }

        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            _isDisposed = true;
            _action();
        }
    }
}
