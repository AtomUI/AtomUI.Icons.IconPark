// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class ThumbsDown : IconParkIcon
{
    public ThumbsDown()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(5.8207700000000004, 5.9628800000000002, 36.158729999999998, 36.037320000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1380008596648159, 0, 0, 1.1380008596648159, -3.3120206319555834, -3.3120206319555834);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M20.3793 29.4002V36.6002C20.3793 39.5826 22.7969 42.0002 25.7793 42.0002L32.9793 25.8002V6.00023H12.0633C10.2682 5.97994 8.73244 7.2853 8.46327 9.06023L5.97927 25.2602C5.82077 26.3045 6.12885 27.3657 6.82192 28.1627C7.51499 28.9597 8.52311 29.4122 9.57927 29.4002H20.3793Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M32.9795 6.00017H37.7855C39.8942 5.96288 41.6968 7.51019 41.9795 9.60017V22.2002C41.6968 24.2901 39.8942 26.0375 37.7855 26.0002H32.9795V6.00017Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

