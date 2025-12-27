// This code is auto generated. Do not modify.

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class SwitchOne : IconParkIcon
{
    public SwitchOne()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(24, 24),
            Radius = 19
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = TransformParser.Parse("rotate(90 36.0063 19.3335)").Value,
            FillBrush = IconBrushType.SecondaryFill,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Rect = new Rect(36.0063, 19.3335, 10.5189, 24.0125),
            RadiusX = 5.25944,
            RadiusY = 5.25944,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = TransformParser.Parse("rotate(-180 36.0063 29.8525)").Value,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Rect = new Rect(36.0063, 29.8525, 10, 10),
            RadiusX = 5,
            RadiusY = 5,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

