// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class KitchenKnife : IconParkIcon
{
    public KitchenKnife()
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
            Data = StreamGeometry.Parse("M14 30C14 30 14 34 14 40C14 46 22 46 22 40C22 34 22 30 22 30"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M22 37H14"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M14 6C14 4.89543 14.8954 4 16 4H32.6349C32.9537 4 33.2672 4.07486 33.5228 4.26546C34.5417 5.0254 37.1977 7.58171 38 14C38.7728 20.1822 36.6313 26.3644 35.6182 28.8547C35.3295 29.5645 34.6334 30 33.8672 30H14V6Z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(22, 10),
            Radius = 2
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

