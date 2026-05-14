// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class GobletOne : IconParkIcon
{
    public GobletOne()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(-0.14253562373095097, -0.14233562373095054, 44.506196654409877, 44.50609665440988);
    internal override Matrix GeneratedZoomMatrix => new Matrix(0.99703929961552151, 0, 0, 0.99703929961552151, 0.071056809227485473, 0.071056809227485473);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M5.73633 24.1211L10.6861 29.0709C15.7629 34.1477 23.9941 34.1477 29.0709 29.0709V29.0709C34.1477 23.994 34.1477 15.7629 29.0709 10.6861L24.1211 5.73632"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M30 29.9998L35.9998 35.9998"),
        },
        new EllipseDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, -0.70710678118654746, 0.70710678118654746, 0.70710678118654757, -5.7989656091546191, 13.999658578643761),
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(13.9996, 13.9998),
            RadiusX = 13,
            RadiusY = 7
        },
        new EllipseDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, -0.70710678118654746, 0.70710678118654746, 0.70710678118654757, -15.740061816787019, 37.999729289321877),
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(37.9997, 37.9998),
            RadiusX = 6,
            RadiusY = 3
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

