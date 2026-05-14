// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class ChartScatter : IconParkIcon
{
    public ChartScatter()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 6, 36, 36);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -3.428571428571427, -3.428571428571427);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M6 6V42H42"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M20 24C22.2091 24 24 22.2091 24 20C24 17.7909 22.2091 16 20 16C17.7909 16 16 17.7909 16 20C16 22.2091 17.7909 24 20 24Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M37 16C39.7614 16 42 13.7614 42 11C42 8.23858 39.7614 6 37 6C34.2386 6 32 8.23858 32 11C32 13.7614 34.2386 16 37 16Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M15 36C16.6569 36 18 34.6569 18 33C18 31.3431 16.6569 30 15 30C13.3431 30 12 31.3431 12 33C12 34.6569 13.3431 36 15 36Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M33 32C34.6569 32 36 30.6569 36 29C36 27.3431 34.6569 26 33 26C31.3431 26 30 27.3431 30 29C30 30.6569 31.3431 32 33 32Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

