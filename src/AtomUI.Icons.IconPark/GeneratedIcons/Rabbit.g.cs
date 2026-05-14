// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Rabbit : IconParkIcon
{
    public Rabbit()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(7, 3.2127300000000001, 34, 40.787269999999999);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.071733106304537, 0, 0, 1.071733106304537, -1.7215945513088897, -1.7215945513088897);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new EllipseDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(24, 32),
            RadiusX = 17,
            RadiusY = 12
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(18, 29.4121),
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
            Center = new Avalonia.Point(24, 35.4121),
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
            Center = new Avalonia.Point(30, 29.4121),
            Radius = 2
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M12.6672 22C11.3521 18.8333 9.06034 11.1127 10.413 5.91273C10.7887 4.91273 12.2164 3.21273 14.9217 4.41273C15.2974 4.57935 16.1616 5.2126 16.6125 6.4126C17.7397 8.4126 16.0489 21 16.0489 21"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M35.3871 22C36.7025 18.8333 38.9324 11.1127 37.5793 5.91273C37.2035 4.91273 35.7754 3.21273 33.0693 4.41273C32.6935 4.57935 31.8291 5.2126 31.378 6.4126C30.2505 8.4126 32.0044 20 32.0044 20"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

