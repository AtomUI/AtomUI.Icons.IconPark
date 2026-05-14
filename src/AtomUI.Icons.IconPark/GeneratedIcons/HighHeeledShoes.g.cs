// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class HighHeeledShoes : IconParkIcon
{
    public HighHeeledShoes()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 8, 40, 32);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -2.1818181818181799, -2.1818181818181799);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M29.1829 20C31.264 15.0536 36.3505 10.6667 39 8C40.1039 8.66667 44 10.6037 44 15C44 19 42.5455 22.1111 41 23L35.0127 27.1911C32.3672 29.0429 30.1414 31.4311 28.48 34.2001L25 40H4V36C6.42869 34.6667 13.8206 30.1333 17 28C24 32 27.5 24 29.1829 20Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M43 21V40"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

