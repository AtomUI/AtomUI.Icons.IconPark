// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class STurnLeft : IconParkIcon
{
    public STurnLeft()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(5.9999900000000004, 4.9999399999999987, 36.000010000000003, 38.000060000000005);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1162775121709132, 0, 0, 1.1162775121709132, -2.7906602921019186, -2.7906602921019186);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M42 38L13 38C8.99999 38 5.99999 35 5.99999 31C5.99999 27 8.99999 24 13 24L19 24"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M19 24L35 24C39 24 42 21 42 17C42 13 39 10 35 10L17 10"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M37 43L42 38L37 33"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(-1, 0, 0, -1, 24, 19.999880000000001),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(12, 9.99994),
            Radius = 5
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

