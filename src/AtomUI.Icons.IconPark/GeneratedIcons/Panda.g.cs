// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Panda : IconParkIcon
{
    public Panda()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(3.5322399999999998, 6.5319599999999998, 40.905360000000002, 37.468040000000002);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0794337290657321, 0, 0, 1.0794337290657321, -1.9064094975775703, -1.9064094975775703);

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
            Center = new Avalonia.Point(24, 27),
            RadiusX = 18,
            RadiusY = 17
        },
        new EllipseDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.96592582628906831, 0.25881904510252074, -0.25881904510252074, 0.96592582628906831, 6.9543412408344514, -3.5430660813624151),
            FillBrush = IconBrushType.SecondaryFill,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(16.9333, 24.6402),
            RadiusX = 3,
            RadiusY = 4
        },
        new EllipseDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(-0.96592599999999995, 0.25881900000000002, 0.25881900000000002, 0.96592599999999995, 30.9329, 24.6402),
            FillBrush = IconBrushType.SecondaryFill,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(0, 0),
            RadiusX = 3,
            RadiusY = 4
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M40.9995 20.999C44.1237 17.8748 44.4376 12.7804 41.3134 9.65616C38.1892 6.53196 32.124 6.87507 28.9998 9.99927"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M7 20.9995C3.87581 17.8753 3.53224 12.7807 6.65644 9.65655C9.78063 6.53236 15.8758 6.87532 19 9.99951"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M20 35C20.5 36.2935 22.2 38.2769 25 35.8623C27.8 38.2769 29.5 36.2935 30 35"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

