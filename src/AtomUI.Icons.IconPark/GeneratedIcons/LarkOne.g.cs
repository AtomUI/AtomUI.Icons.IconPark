// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class LarkOne : IconParkIcon
{
    public LarkOne()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(3.4938099999999999, 6.3223200000000004, 38.183890000000005, 38.266980000000004);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0805194056783096, 0, 0, 1.0805194056783096, -1.9324657362794326, -1.9324657362794326);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M3.49381 17.7193L41.6776 6.32232L30.3639 44.5893L21.4834 35.7089L21.5251 26.4749L11.9791 26.2045L3.49381 17.7193Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M27.5352 14.8908C25.9731 16.4529 25.9731 18.9856 27.5352 20.5477C29.0973 22.1098 31.63 22.1098 33.1921 20.5477C34.7542 18.9856 34.7542 16.4529 33.1921 14.8908C31.63 13.3287 29.0973 13.3287 27.5352 14.8908Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M41.6777 6.40558L30.364 17.7193"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

