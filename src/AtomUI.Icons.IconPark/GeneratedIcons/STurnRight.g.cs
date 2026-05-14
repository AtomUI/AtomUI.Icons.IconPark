// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class STurnRight : IconParkIcon
{
    public STurnRight()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 4.9999399999999987, 36.175800000000002, 38.000060000000005);
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
            Data = StreamGeometry.Parse("M30 24L13 24C9 24 6 21 6 17C6 13 9 10 13 10L32 10"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M8 38L35 38C39 38 42 35 42 31C42 27 39 24 35 24L30 24"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M13 43L8 38L13 33"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(-1, 0, 0, -1, 74.351600000000005, 19.999880000000005),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(37.1758, 9.99994),
            Radius = 5
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

