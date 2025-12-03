// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class FolderMusic : IconParkIcon
{
    public FolderMusic()
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
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M5 8C5 6.89543 5.89543 6 7 6H19L24 12H41C42.1046 12 43 12.8954 43 14V40C43 41.1046 42.1046 42 41 42H7C5.89543 42 5 41.1046 5 40V8Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M30 20L26 20.9688V30.5"),
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
            Center = new Avalonia.Point(22, 30),
            Radius = 4
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

