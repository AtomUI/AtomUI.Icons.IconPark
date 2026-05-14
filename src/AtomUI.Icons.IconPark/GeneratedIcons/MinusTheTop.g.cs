// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class MinusTheTop : IconParkIcon
{
    public MinusTheTop()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 5, 38, 38);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1162790697674418, 0, 0, 1.1162790697674418, -2.7906976744186025, -2.7906976744186025);

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
            Data = StreamGeometry.Parse("M5 41V21C5 19.8954 5.89543 19 7 19H19H27C28.1046 19 29 19.8954 29 21V29V41C29 42.1046 28.1046 43 27 43H7C5.89543 43 5 42.1046 5 41Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M43 7V27C43 28.1046 42.1046 29 41 29H31C29.8954 29 29 28.1046 29 27V21C29 19.8954 28.1046 19 27 19H21C19.8954 19 19 18.1046 19 17V7C19 5.89543 19.8954 5 21 5H41C42.1046 5 43 5.89543 43 7Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

