// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class LipstickOne : IconParkIcon
{
    public LipstickOne()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(5.4941050633883357, 5.3227500000000001, 36.916794936611666, 38.183739873223331);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1470079426616977, 0, 0, 1.1470079426616977, -3.5281906238807466, -3.5281906238807466);

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
            Data = StreamGeometry.Parse("M39.4346 5.32275L40.8488 6.73697C42.4109 8.29906 42.4109 10.8317 40.8488 12.3938L33.7777 19.4649L29.5351 15.2222L39.4346 5.32275Z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, 0.70710678118654746, -0.70710678118654746, 0.70710678118654757, 17.999927087486348, -15.840468096336394),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(28.1211, 13.8076, 10, 16),
            RadiusX = 0,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, 0.70710678118654746, -0.70710678118654746, 0.70710678118654757, 21.272415068106834, -3.9411529618533132),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(15.3936, 23.7075, 14, 14),
            RadiusX = 0,
            RadiusY = 0,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

