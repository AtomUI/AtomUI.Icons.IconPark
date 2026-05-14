// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class StorageCardOne : IconParkIcon
{
    public StorageCardOne()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 49, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 49, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(8.7778299999999998, 4, 31.999969999999998, 40);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0909090909090908, 0, 0, 1.0909090909090908, -2.2272727272727266, -2.1818181818181799);

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
            Data = StreamGeometry.Parse("M33.7778 4H15.7778V12H33.7778V4Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M15.3661 4H10.7778C9.67326 4 8.77783 4.89543 8.77783 6V42C8.77783 43.1046 9.67326 44 10.7778 44H38.7778C39.8824 44 40.7778 43.1046 40.7778 42V6C40.7778 4.89543 39.8824 4 38.7778 4H34.1896"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M27.7775 20L19.7778 28.0012H29.7818L21.7781 36.0018"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

