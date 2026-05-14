// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class VrGlasses : IconParkIcon
{
    public VrGlasses()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(2, 12, 44, 24);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0434782608695652, 0, 0, 1.0434782608695652, -1.0434782608695627, -1.0434782608695627);

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
            Data = StreamGeometry.Parse("M2 12H46V36H30L24 30L18 36H2V12Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryFill,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M13 28C15.2091 28 17 26.2091 17 24C17 21.7909 15.2091 20 13 20C10.7909 20 9 21.7909 9 24C9 26.2091 10.7909 28 13 28Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryFill,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M35 28C37.2091 28 39 26.2091 39 24C39 21.7909 37.2091 20 35 20C32.7909 20 31 21.7909 31 24C31 26.2091 32.7909 28 35 28Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

