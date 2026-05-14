// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Deer : IconParkIcon
{
    public Deer()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(2.989222359914347, 4, 42.020787140085659, 40);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0664112578506577, 0, 0, 1.0664112578506577, -1.5938701884157851, -1.5938701884157851);

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
            Data = StreamGeometry.Parse("M36 27C36 34.2165 30.6274 44 24 44C17.3726 44 12 34.2165 12 27C12 19.7835 13.5 16 24 16C34.5 16 36 19.7835 36 27Z"),
        },
        new EllipseDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710700000000004, -0.70710700000000004, -0.70710700000000004, -0.70710700000000004, 38.999600000000001, 17.500299999999999),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(0, 0),
            RadiusX = 5,
            RadiusY = 3.5
        },
        new EllipseDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, 0.70710678118654746, -0.70710678118654746, 0.70710678118654757, 15.010087137560337, -1.2381559399001141),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(8.99963, 17.4997),
            RadiusX = 5,
            RadiusY = 3.5
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M12 4C12 10.6274 17.3726 16 24 16C30.6274 16 36 10.6274 36 4"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M18 7C18 11.9706 20.6863 16 24 16C27.3137 16 30 11.9706 30 7"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(19.9995, 26),
            Radius = 2
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(23.9995, 34),
            Radius = 2
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(27.9995, 26),
            Radius = 2
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

