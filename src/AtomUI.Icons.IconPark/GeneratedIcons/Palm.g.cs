// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Palm : IconParkIcon
{
    public Palm()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(7.18736, 4, 32.812640000000002, 40);
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
            Data = StreamGeometry.Parse("M18.3332 35.8132L8.61924 24.9336C7.18736 23.3298 7.36957 20.8587 9.02119 19.4823C10.6566 18.1195 13.0924 18.3655 14.4223 20.0279L16 22V8.99391C16 7.33944 17.3394 5.99728 18.9939 5.99391C20.6531 5.99054 22 7.33467 22 8.99391V7C22 5.34315 23.3431 4 25 4C26.6569 4 28 5.34315 28 7V8.82927C28 7.17241 29.3431 5.82927 31 5.82927C32.6569 5.82927 34 7.17241 34 8.82927V12.1463C34 10.4895 35.3431 9.14634 37 9.14634C38.6569 9.14634 40 10.4895 40 12.1463V25.8278C40 27.9688 39.3219 30.0547 38.0631 31.7864L35.23 35.6836C35.0855 35.8824 34.8546 36 34.6089 36H18.7504C18.5911 36 18.4393 35.9321 18.3332 35.8132Z"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(19, 36, 16, 8),
            RadiusX = 1,
            RadiusY = 1,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

