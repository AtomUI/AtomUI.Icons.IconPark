// This code is auto generated. Do not modify.

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class Distortion : IconParkIcon
{
    public Distortion()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M4 19V40H17M4 19V8H17M4 19C4 19 13 13 24 19C35 25 44 19 44 19M44 19V8H17M44 19V40H17M4 29C4 29 13 23 24 29C35 35 44 29 44 29M17 8C17 8 23 16 17 24C11 32 17 40 17 40M31 8C31 8 37 16 31 24C25 32 31 40 31 40"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

