// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class ClothesBriefs : IconParkIcon
{
    public ClothesBriefs()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6, 14, 36, 23);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1428571428571428, 0, 0, 1.1428571428571428, -3.428571428571427, -3.428571428571427);

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
            Data = StreamGeometry.Parse("M22.1579 37C22.1579 37 21.2572 28.9255 18 25C14.956 21.3315 6 19 6 19L6 14H42L42 19C42 19 33.044 21.3315 30 25C26.7428 28.9254 25.8421 37 25.8421 37H22.1579Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

