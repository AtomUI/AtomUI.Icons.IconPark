// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class WalletThree : IconParkIcon
{
    public WalletThree()
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
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M39 16V9C39 7.34315 37.6569 6 36 6H9C7.34315 6 6 7.34315 6 9V39C6 40.6569 7.34314 42 9 42H36C37.6569 42 39 40.6569 39 39V32"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(22, 16, 20, 16),
            RadiusX = 3,
            RadiusY = 0,
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            Transform = TransformParser.Parse("matrix(-1.31134e-07 -1 -1 1.31134e-07 30 24)").Value,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(0, 0),
            Radius = 2
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

