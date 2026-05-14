// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Effects : IconParkIcon
{
    public Effects()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.3322799999999999, 4.6073199999999996, 39.845420000000004, 39.410579999999996);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1121991095919297, 0, 0, 1.1121991095919297, -2.6927786302063126, -2.6927786302063126);

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
            Data = StreamGeometry.Parse("M24.9507 42.3603L30.4164 30.3695L43.1046 26.6501L33.3383 17.7699L33.7059 4.60732L22.2044 11.1099L9.74329 6.69439L12.4013 19.5934L4.33228 30.027L17.4766 31.4965L24.9507 42.3603Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M36.1777 36.0537L44.1777 44.0179"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

