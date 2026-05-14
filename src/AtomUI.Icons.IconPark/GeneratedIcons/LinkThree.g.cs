// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class LinkThree : IconParkIcon
{
    public LinkThree()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(3.4947779386421445, 3.4939, 41.012116997969521, 41.012216997969517);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0785231093604284, 0, 0, 1.0785231093604284, -1.8845546246502813, -1.8845546246502813);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, 0.70710678118654746, -0.70710678118654746, 0.70710678118654757, 12.60683316355235, -23.447787602022998),
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(34.6074, 3.4939, 14, 18),
            RadiusX = 2,
            RadiusY = 2,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, 0.70710678118654746, -0.70710678118654746, 0.70710678118654757, 20.222095954391108, -5.0630583127011226),
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(16.2227, 21.8787, 14, 18),
            RadiusX = 2,
            RadiusY = 2,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M31.0723 16.929L16.9301 31.0711"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

