// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class HexagonOne : IconParkIcon
{
    public HexagonOne()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 4.2040199999999999, 36, 39.59198);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0959915024125513, 0, 0, 1.0959915024125513, -2.3037960579012307, -2.3037960579012307);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M23.0287 43.4604L7.02871 34.5715C6.39378 34.2188 6 33.5495 6 32.8232V15.1768C6 14.4505 6.39378 13.7812 7.02872 13.4285L23.0287 4.5396C23.6328 4.20402 24.3672 4.20402 24.9713 4.5396L40.9713 13.4285C41.6062 13.7812 42 14.4505 42 15.1768V32.8232C42 33.5495 41.6062 34.2188 40.9713 34.5715L24.9713 43.4604C24.3672 43.796 23.6328 43.796 23.0287 43.4604Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

