// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Sleep : IconParkIcon
{
    public Sleep()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 7.4692400000000001, 35.134300000000003, 34.530760000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -3.428571428571427, -3.428571428571427);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M16.8657 7.46924C16.3036 9.21181 16 11.0705 16 13C16 22.9411 24.0589 31 34 31C36.5346 31 38.9468 30.4762 41.1343 29.5308C38.8006 36.766 32.0116 42 24 42C14.0589 42 6 33.9411 6 24C6 16.5935 10.4734 10.2317 16.8657 7.46924Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M31.6605 10H41L31 18H41"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

