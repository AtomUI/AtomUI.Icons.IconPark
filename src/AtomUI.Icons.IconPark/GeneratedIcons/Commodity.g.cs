// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Commodity : IconParkIcon
{
    public Commodity()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(6.1318000000000001, 8, 35.736400000000003, 32);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1464548272913571, 0, 0, 1.1464548272913571, -3.5149158549925694, -3.5149158549925694);

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
            Data = StreamGeometry.Parse("M9.78101 9.75193C9.90612 8.75107 10.7569 8 11.7656 8H36.2344C37.2431 8 38.0939 8.75107 38.219 9.75193L41.719 37.7519C41.8682 38.9456 40.9374 40 39.7344 40H8.26556C7.06257 40 6.1318 38.9456 6.28101 37.7519L9.78101 9.75193Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M15 18C15 18 17 22 24 22C31 22 33 18 33 18"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

