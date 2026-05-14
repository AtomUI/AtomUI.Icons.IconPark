// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class ThreeTriangles : IconParkIcon
{
    public ThreeTriangles()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.0097699999999996, 7, 39.980729999999994, 34.5);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0911580733421897, 0, 0, 1.0911580733421897, -2.1877937602125535, -2.1877937602125535);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M17.0001 7L24.0001 19.1244L29.9905 29.5H4.00977L17.0001 7Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M31.0001 7L43.9905 29.5H18.0098L24.0001 19.1244L31.0001 7Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M11.0098 41.5H36.9905L29.9905 29.5H18.0098L11.0098 41.5Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M29.9905 29.5L24.0001 19.1244M18.0098 29.5L11.0098 41.5H36.9905L29.9905 29.5H18.0098ZM18.0098 29.5H43.9905L31.0001 7L24.0001 19.1244L18.0098 29.5ZM18.0098 29.5L24.0001 19.1244L18.0098 29.5ZM18.0098 29.5H29.9905H18.0098ZM29.9905 29.5H4.00977L17.0001 7L24.0001 19.1244L29.9905 29.5Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

