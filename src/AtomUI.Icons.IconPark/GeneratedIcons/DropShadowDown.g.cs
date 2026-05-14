// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class DropShadowDown : IconParkIcon
{
    public DropShadowDown()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(8, 5, 32, 38);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1162790697674418, 0, 0, 1.1162790697674418, -2.7906976744186025, -2.7906976744186025);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M24 37C28.4183 37 32.4183 35.2091 35.3138 32.3138C38.2091 29.4183 40 25.4183 40 21C40 16.5817 38.2091 12.5817 35.3138 9.68629C32.4183 6.79086 28.4183 5 24 5C19.5817 5 15.5817 6.79086 12.6863 9.68629C9.79086 12.5817 8 16.5817 8 21C8 25.4183 9.79086 29.4183 12.6863 32.3138C15.5817 35.2091 19.5817 37 24 37Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M39.5562 36.5564C35.5749 40.5374 30.0749 43 23.9997 43C17.9246 43 12.4246 40.5374 8.44336 36.5564"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

