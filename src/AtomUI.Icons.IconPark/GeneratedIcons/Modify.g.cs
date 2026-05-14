// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Modify : IconParkIcon
{
    public Modify()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.9079151901650029, 4.5621900000000002, 38.183766184073562, 38.529776184073569);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1050280849794223, 0, 0, 1.1050280849794223, -2.5206740395061331, -2.5206740395061331);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M20.0708 9.58588L15.8282 5.34324C15.0472 4.56219 13.7808 4.56219 12.9998 5.34324L7.34292 11.0001C6.56188 11.7811 6.56188 13.0475 7.34292 13.8285L11.5856 18.0712"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M28.9287 37.4143L33.1714 41.6569C33.9524 42.438 35.2187 42.438 35.9998 41.6569L41.6566 36.0001C42.4377 35.219 42.4377 33.9527 41.6566 33.1717L37.414 28.929"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, 0.70710678118654746, -0.70710678118654746, 0.70710678118654757, 13.606601390965672, -23.032841615873949),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(34.6064, 4.9082, 12, 42),
            RadiusX = 2,
            RadiusY = 2,
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(24, 24),
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
            Center = new Avalonia.Point(20, 28),
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
            Center = new Avalonia.Point(28, 20),
            Radius = 2
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

