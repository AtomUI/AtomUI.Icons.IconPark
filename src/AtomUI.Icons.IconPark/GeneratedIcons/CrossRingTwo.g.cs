// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class CrossRingTwo : IconParkIcon
{
    public CrossRingTwo()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 14, 40, 16);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -2.1818181818181799, -2.1818181818181799);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M19.4545 26.4444C17.6364 28.2222 15.8182 30 12.1818 30C8.54545 30 4 27.3333 4 22C4 16.6667 8.54545 14 12.1818 14C17.6364 14 20.3636 17.5556 24 22C27.6364 26.4444 30.3636 30 35.8182 30C39.4545 30 44 27.3333 44 22C44 16.6667 39.4545 14 35.8182 14C32.1818 14 29.4545 16.6667 28.5455 17.5556"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

