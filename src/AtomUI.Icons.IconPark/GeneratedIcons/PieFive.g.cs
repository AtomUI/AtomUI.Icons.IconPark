// This code is auto generated. Do not modify.
// Generated Date: 2025-12-26

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class PieFive : IconParkIcon
{
    public PieFive()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(24, 24),
            Radius = 20
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M24 4C27.2624 4 30.4754 4.79809 33.3586 6.32469C36.2418 7.85128 38.7078 10.06 40.5416 12.7583C42.3754 15.4566 43.5212 18.5626 43.8792 21.8053C44.2372 25.0481 43.7965 28.3291 42.5955 31.3625C41.3945 34.3958 39.4697 37.0893 36.989 39.2081C34.5082 41.3269 31.5467 42.8067 28.3629 43.5183C25.179 44.23 21.8694 44.152 18.7225 43.2911C15.5757 42.4303 12.6873 40.8127 10.3091 38.5794L24 24V4Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

