// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Handheld : IconParkIcon
{
    public Handheld()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 4, 36, 40);
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
            Data = StreamGeometry.Parse("M42 18V44H6V18"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M42 4H6V18H42V4Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M16 27V35"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M12 31H20"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M32 35C34.2091 35 36 33.2091 36 31C36 28.7909 34.2091 27 32 27C29.7909 27 28 28.7909 28 31C28 33.2091 29.7909 35 32 35Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

