// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class EggOne : IconParkIcon
{
    public EggOne()
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
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M29 22.1333C29 30.9699 23.6274 36 17 36C10.3726 36 5 30.9699 5 22.1333C5 11.1634 11.3726 4 17 4C22.6274 4 29 11.1634 29 22.1333Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M29 24.0684C37.5365 24.7022 43 29.6217 43 33.9999C43 38.6894 36.732 43.9999 27.1333 43.9999C20.3603 43.9999 16.143 40.5644 15.2011 36"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

