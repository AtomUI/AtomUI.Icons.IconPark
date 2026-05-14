// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class ChartProportion : IconParkIcon
{
    public ChartProportion()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 4, 40, 40.000100000000003);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909115702535688, 0, 0, 1.0909115702535688, -2.1818776860856488, -2.1818776860856488);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M16.3446 5.51758C13.9 6.53124 11.7001 8.01574 9.85786 9.85797C6.23858 13.4773 4 18.4773 4 24.0001C4 35.0458 12.9543 44.0001 24 44.0001V44.0001C29.5228 44.0001 34.5228 41.7615 38.1421 38.1422C39.9844 36.3 41.4689 34.1001 42.4825 31.6555"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M24 24H44C44 12.9543 35.0457 4 24 4L24 24Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

