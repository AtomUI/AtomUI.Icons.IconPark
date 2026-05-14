// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Egg : IconParkIcon
{
    public Egg()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.0001199999999999, 4, 39.999980000000001, 40);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909115702535688, 0, 0, 1.0909115702535688, -2.1818776860856488, -2.1818776860856488);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(24, 24),
            Radius = 10
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M44.0001 24C44.0001 26.6325 43.4915 29.1463 42.5672 31.4483C41.6312 33.7794 38.4382 31.5194 35.2215 34.9695C32.0049 38.4196 34.5105 41.2363 32.017 42.3284C29.5627 43.4035 26.8511 44 24.0001 44C12.9544 44 4.00012 35.0457 4.00012 24C4.00012 12.9543 12.9544 4 24.0001 4C35.0458 4 44.0001 12.9543 44.0001 24Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M20 25C20 25 20.2109 26.2109 21 27C21.7891 27.7891 23 28 23 28"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

