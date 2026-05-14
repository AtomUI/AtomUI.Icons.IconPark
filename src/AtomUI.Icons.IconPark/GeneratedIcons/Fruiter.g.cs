// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Fruiter : IconParkIcon
{
    public Fruiter()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 4, 36.059100000000001, 40);
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
            Data = StreamGeometry.Parse("M19 32.0003C15 32 6 32.1309 6 22.941C6 21.192 6.59395 17.6967 9.8653 15.6125C10.5277 15.1905 10.9894 14.4933 11.1004 13.7159C11.5991 10.2257 14.1089 4 22 4C24.2925 4 27.9884 4.29995 30.3835 7.93C30.8001 8.56136 31.4798 8.98871 32.2221 9.13376C35.7901 9.83088 42.0582 13.2757 42 20C42.0591 22.1704 41.5574 25.3457 37.494 27.3697C36.6482 27.791 36.1153 28.6832 35.9478 29.6132C35.497 32.117 33.2767 35.3748 27 36"),
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
            Data = StreamGeometry.Parse("M16 44C23.0933 31.0694 18.9556 25.3469 16 24L30 22C23.28 31.3388 26.5778 40.5578 29.0667 44H16Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

