// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class SwitchOne : IconParkIcon
{
    public SwitchOne()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 5, 38, 38);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1162790697674418, 0, 0, 1.1162790697674418, -2.7906976744186025, -2.7906976744186025);

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
            Transform = new Matrix(0, 1, -1, 0, 55.339799999999997, -16.672800000000006),
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
            Transform = new Matrix(-1, 0, 0, -1, 72.012600000000006, 59.705000000000005),
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

