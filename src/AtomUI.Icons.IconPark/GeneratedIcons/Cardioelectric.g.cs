// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Cardioelectric : IconParkIcon
{
    public Cardioelectric()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 6, 40, 36);
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
            Data = StreamGeometry.Parse("M5.55469 23.194C5.3698 22.8031 5.19795 22.4068 5.04108 22.0056C4.39264 20.3473 4 18.6042 4 16.8C4 10.8353 8.88417 6 14.9091 6C18.7036 6 22.0456 7.91792 24 10.828C25.9544 7.91792 29.2964 6 33.0909 6C39.1158 6 44 10.8353 44 16.8C44 24.5647 36.7273 31.2 33.0909 34.8C30.6667 37.2 27.6364 39.6 24 42C20.3636 39.6 17.3333 37.2 14.9091 34.8C14.543 34.4376 14.1401 34.0444 13.7114 33.6224"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M8 29.9734L19.1138 19.0396L25.5781 25.7059L35.2619 15.8188"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

