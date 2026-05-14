// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class OvalLoveTwo : IconParkIcon
{
    public OvalLoveTwo()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(1.4769099999999999, 3.0897700000000001, 44.820690000000006, 41.820630000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0317457417381348, 0, 0, 1.0317457417381348, -0.7618978017152358, -0.7618978017152358);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M23.7839 10.372C18.6739 5.81238 12.6448 4.14698 8.25809 6.67962C2.04029 10.2694 1.47691 20.9342 6.99976 30.5001C10.6308 36.7892 15.9885 41.0375 21 42.1899"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M18.2581 17.5001C12.7353 27.0659 13.2986 37.7307 19.5164 41.3206C25.7342 44.9104 35.2519 40.0659 40.7748 30.5001C46.2976 20.9342 45.7342 10.2694 39.5164 6.67962C33.2986 3.08977 23.7809 7.93428 18.2581 17.5001Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

