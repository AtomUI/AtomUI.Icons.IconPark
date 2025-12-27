// This code is auto generated. Do not modify.

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class Stamp : IconParkIcon
{
    public Stamp()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M5 8.8L8.8 5L12.6 7.85L16.4 5L20.2 7.85L24 5L27.8 7.85L31.6 5L35.4 7.85L39.2 5L43 8.8L40.15 12.6L43 16.4L40.15 20.2L43 24L40.15 27.8L43 31.6L40.15 35.4L43 39.2L39.2 43L35.4 40.15L31.6 43L27.8 40.15L24 43L20.2 40.15L16.4 43L12.6 40.15L8.8 43L5 39.2L7.85 35.4L5 31.6L7.85 27.8L5 24L7.85 20.2L5 16.4L7.85 12.6L5 8.8Z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryFill,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(24, 24),
            Radius = 9
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

