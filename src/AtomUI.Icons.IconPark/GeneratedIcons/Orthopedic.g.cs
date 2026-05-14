// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Orthopedic : IconParkIcon
{
    public Orthopedic()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.2940100000000001, 2.94746, 40.201990000000002, 41.18094);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0654227264433924, 0, 0, 1.0654227264433924, -1.5701454346414181, -1.5701454346414181);

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
            Data = StreamGeometry.Parse("M23.0283 36L34.0026 42.9987V24C41.6769 18.7896 44.496 13.9783 42.4597 9.56594C39.4054 2.94746 34.4604 3.38382 31.0068 5.00174C28.7044 6.08035 27.0354 9.09334 25.9998 14.0407C22.9616 7.57467 18.6951 4.34165 13.2002 4.34165C4.95788 4.34165 4.29401 14.0648 5.47501 16.446C6.656 18.8273 7.77278 20.1122 13.0007 24C12.9255 35.5632 13.4061 41.7818 14.4426 42.6557C16.3435 44.1284 19.2054 41.9098 23.0283 36Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M27 25V31"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

