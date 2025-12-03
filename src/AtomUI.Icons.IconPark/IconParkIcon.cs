using System.Diagnostics;
using AtomUI.Controls;
using Avalonia.Media;
using Avalonia.Media.Immutable;

namespace AtomUI.Icons.IconPark;

public class IconParkIcon : Icon
{
    static IconParkIcon()
    {
        AffectsMeasure<IconParkIcon>(IconThemeProperty);
    }

    public override IBrush? FindIconBrush(IconBrushType brushType)
    {
        if (IconTheme == IconThemeType.Outlined)
        {
            brushType = brushType switch
            {
                IconBrushType.Stroke => IconBrushType.Stroke,
                IconBrushType.SecondaryStroke => IconBrushType.Stroke,
                _ => IconBrushType.None
            };
        }
        else if (IconTheme == IconThemeType.Filled ||
                 IconTheme == IconThemeType.Rounded ||
                 IconTheme == IconThemeType.Sharp)
        {
            brushType = brushType switch
            {
                IconBrushType.Stroke => IconBrushType.Stroke,
                IconBrushType.Fill => IconBrushType.Stroke,
                IconBrushType.SecondaryStroke => IconBrushType.Fallback,
                IconBrushType.SecondaryFill => IconBrushType.Fallback,
                _ => IconBrushType.None
            };
        }
        else if (IconTheme == IconThemeType.TwoTone)
        {
            brushType = brushType switch
            {
                IconBrushType.Stroke => IconBrushType.Stroke,
                IconBrushType.Fill => IconBrushType.Fill,
                IconBrushType.SecondaryStroke => IconBrushType.Stroke,
                IconBrushType.SecondaryFill => IconBrushType.Fill,
                _ => IconBrushType.None
            };
        }
        else if (IconTheme == IconThemeType.MultiColor)
        {
            brushType = brushType switch
            {
                IconBrushType.Stroke => IconBrushType.Stroke,
                IconBrushType.Fill => IconBrushType.Fill,
                IconBrushType.SecondaryStroke => IconBrushType.SecondaryStroke,
                IconBrushType.SecondaryFill => IconBrushType.SecondaryFill,
                _ => IconBrushType.None
            };
        }

        if (brushType == IconBrushType.None)
        {
            return null;
        }

        var index = (int)brushType;
        Debug.Assert(index >= 0 && index < DrawBrushes.Length);
        return DrawBrushes[index];
    }

    protected override IBrush? ProcessBrush(IBrush? brush)
    {
        if (brush is ImmutableSolidColorBrush immutableSolidColorBrush)
        {
            var color = immutableSolidColorBrush.Color;
            if (color.A > 0 && color.A < 255)
            {
                color = color.ToOpaqueOnWhite();
                brush = new SolidColorBrush(color);
            }
        }

        return base.ProcessBrush(brush);
    }
}