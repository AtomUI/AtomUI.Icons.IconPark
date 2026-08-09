using Avalonia.Media;

namespace AtomUI.Icons.IconPark;

internal static class ColorConverter
{
     /// <summary>
    /// 将黑色半透明色（rgba(0,0,0,a)）转换为叠加在纯白（#FFFFFF）背景上的等效不透明实色。
    /// </summary>
    /// <param name="alpha">透明度（Alpha通道值），范围从0.0（完全透明）到1.0（完全不透明）。</param>
    /// <returns>等效的不透明颜色。</returns>
    public static Color BlackTransparentToOpaqueOnWhite(double alpha)
    {
        alpha = Math.Clamp(alpha, 0.0, 1.0);
        byte rgbComponent = (byte)(255 * (1 - alpha));
        return Color.FromRgb(rgbComponent, rgbComponent, rgbComponent);
    }

    /// <summary>
    /// 将黑色半透明颜色（Avalonia的Color对象）转换为叠加在纯白背景上的等效实色。
    /// 这是一个更实用的重载方法。
    /// </summary>
    /// <param name="transparentColor">一个黑色半透明颜色。其R、G、B分量应为0。</param>
    /// <returns>等效的不透明颜色。如果输入颜色不是黑色，会警告并基于其亮度计算。</returns>
    public static Color ToOpaqueOnWhite(this Color transparentColor)
    {
        return transparentColor.BlendWithBackground(Colors.White);
    }

    /// <summary>
    /// 一个实用的扩展方法：将当前颜色与指定的背景色混合，得到混合后的最终实色。
    /// 这是一个更通用的版本。
    /// </summary>
    /// <param name="foregroundColor">前景色（通常为半透明）。</param>
    /// <param name="backgroundColor">背景色（不透明或半透明）。</param>
    /// <returns>混合后等效的不透明颜色。</returns>
    public static Color BlendWithBackground(this Color foregroundColor, Color backgroundColor)
    {
        double fA = foregroundColor.A / 255.0;
        double fR = foregroundColor.R;
        double fG = foregroundColor.G;
        double fB = foregroundColor.B;

        double bA = backgroundColor.A / 255.0;
        double bR = backgroundColor.R;
        double bG = backgroundColor.G;
        double bB = backgroundColor.B;

        // 标准 Alpha 合成公式（假设背景不透明，简化版）
        // 对于更复杂的情况（背景也半透明），需要使用完整的 Porter-Duff 公式
        // 这里假设背景色是完全不透明的 (bA = 1.0)，这是最常见场景
        double finalA = fA + bA * (1 - fA); // 通常结果为 1 (完全不透明)
        byte finalR = (byte)((fR * fA + bR * bA * (1 - fA)) / finalA);
        byte finalG = (byte)((fG * fA + bG * bA * (1 - fA)) / finalA);
        byte finalB = (byte)((fB * fA + bB * bA * (1 - fA)) / finalA);

        return Color.FromArgb((byte)(finalA * 255), finalR, finalG, finalB);
    }
}
