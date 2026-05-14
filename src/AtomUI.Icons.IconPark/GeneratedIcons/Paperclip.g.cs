// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Paperclip : IconParkIcon
{
    public Paperclip()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(2.0802299999999998, 3.4940500000000001, 42.426369999999999, 38.183749999999996);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.045301402859814, 0, 0, 1.045301402859814, -1.0872336686355339, -1.0872336686355339);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M26.1219 37.4352C26.1219 37.4352 37.4356 26.1215 40.264 23.293C43.0924 20.4646 44.5066 13.3935 39.5569 8.4438C34.6071 3.49405 27.5361 4.90826 24.7076 7.73669C21.8792 10.5651 7.02998 25.4144 5.61576 26.8286C4.20155 28.2428 2.08023 33.1925 6.32287 37.4352C10.5655 41.6778 15.5153 39.5565 16.9295 38.1423C18.3437 36.7281 33.9 21.1717 35.3142 19.7575C36.7285 18.3433 37.4356 14.8078 35.3142 12.6864C33.1929 10.5651 29.6574 11.2722 28.2432 12.6864C26.829 14.1007 14.8082 26.1215 14.8082 26.1215"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

