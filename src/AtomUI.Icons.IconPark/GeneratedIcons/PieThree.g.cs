// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class PieThree : IconParkIcon
{
    public PieThree()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 4, 40.373100000000001, 40);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1002386142494653, 0, 0, 1.1002386142494653, -2.4057267419871664, -2.4057267419871664);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(24, 24),
            Radius = 20
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M24 4C27.9021 4 31.719 5.14149 34.9805 7.28385C38.2419 9.42621 40.8054 12.4758 42.3551 16.057C43.9048 19.6382 44.3731 23.5946 43.7022 27.4386C43.0313 31.2826 41.2506 34.8464 38.5794 37.6909L24 24V4Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

