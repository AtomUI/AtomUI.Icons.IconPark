// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class CannedFruit : IconParkIcon
{
    public CannedFruit()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(8, 6, 32, 37);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1707317073170731, 0, 0, 1.1707317073170731, -4.0975609756097526, -4.0975609756097526);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M15 24C15 24 14.5 27 16 33"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M37.5666 12C38.7278 14.8106 40 18.6419 40 21.9375C40 25.8154 38.6546 33.3501 37.6851 38.2768C37.1408 41.0424 34.7033 43 31.8847 43H16.0422C13.257 43 10.8392 41.0861 10.2804 38.3575C9.31371 33.6374 8 26.4016 8 21.9375C8 18.2592 9.44361 14.6318 10.8271 12"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M11.5868 6.45675C11.7711 6.17196 12.0872 6 12.4264 6H35.5736C35.9128 6 36.2289 6.17196 36.4132 6.45675L39.0014 10.4567C39.432 11.1221 38.9544 12 38.1619 12H9.83814C9.04564 12 8.56805 11.1221 8.99857 10.4567L11.5868 6.45675Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

