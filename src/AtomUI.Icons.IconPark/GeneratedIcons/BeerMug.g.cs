// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class BeerMug : IconParkIcon
{
    public BeerMug()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 4, 35.5, 40);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -2.1818181818181799, -2.1818181818181799);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M16 37.2414C16 39.1724 16.8571 44 28 44C39.1429 44 40 39.1724 40 37.2414C40 35.3103 40 16 40 16H28H16C16 16 16 35.3103 16 37.2414Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M25 23V37"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M31 23V37"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M15.9983 16C15.9983 16 13.9992 11.5 16.9988 9C19.9983 6.5 22.9991 8 22.9991 8C22.9991 8 23.9983 4 27.9991 4C32 4 32.9985 8 32.9985 8C32.9985 8 36.5 6.5 39 9C41.5 11.5 39.9985 16 39.9985 16"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M16 19H6C6 19 7 29 7.9991 32C8.99821 35 16 34 16 34"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

