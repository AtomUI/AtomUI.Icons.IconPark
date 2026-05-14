// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class ElectronicPen : IconParkIcon
{
    public ElectronicPen()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 5.3222699999999961, 37.677881374238567, 37.677730000000004);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1516983851439631, 0, 0, 1.1516983851439631, -3.6407612434551133, -3.6407612434551133);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, 0.70710678118654746, -0.70710678118654746, 0.70710678118654757, 14.071087100720032, -23.326069315891417),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Rect = new Rect(35.1926, 5.32227, 12, 38),
            RadiusX = 6,
            RadiusY = 6,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M18 23L26 31"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M6 43L12 37"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.86602540378443871, 0.49999999999999994, -0.49999999999999994, 0.86602540378443871, 10.626880264358913, -14.980857072538456),
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Rect = new Rect(33.2681, 12.3396, 4, 4),
            RadiusX = 2,
            RadiusY = 2,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

