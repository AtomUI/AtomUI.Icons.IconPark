// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class BatteryTips : IconParkIcon
{
    public BatteryTips()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(14, 2, 20, 42);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -1.0434782608695627, -1.0434782608695627);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0, -1, 1, 0, -30, 57.999999999999993),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(14, 44, 36, 20),
            RadiusX = 2,
            RadiusY = 2,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M20 6L20 4C20 2.89543 20.8954 2 22 2L26 2C27.1046 2 28 2.89543 28 4L28 6L20 6Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M24 28L24 18"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(-1.3113399999999999E-07, -1, -1, 1.3113399999999999E-07, 24, 34),
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

