// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Skate : IconParkIcon
{
    public Skate()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(3.8574199999999998, 7.2011700000000003, 40.142580000000002, 32.618630000000003);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0873854677275321, 0, 0, 1.0873854677275321, -2.09725122546077, -2.09725122546077);

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
            Data = StreamGeometry.Parse("M44 39.8198H4L36.54 21.8198H44V39.8198Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M3.85742 19.2012L7.08947 20.7992L24.41 10.7992L24.642 7.20117"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M12.3301 24.8799C13.9869 24.8799 15.3301 23.5367 15.3301 21.8799C15.3301 20.223 13.9869 18.8799 12.3301 18.8799C10.6732 18.8799 9.33008 20.223 9.33008 21.8799C9.33008 23.5367 10.6732 24.8799 12.3301 24.8799Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Data = StreamGeometry.Parse("M23.4502 18.8799C25.107 18.8799 26.4502 17.5367 26.4502 15.8799C26.4502 14.223 25.107 12.8799 23.4502 12.8799C21.7933 12.8799 20.4502 14.223 20.4502 15.8799C20.4502 17.5367 21.7933 18.8799 23.4502 18.8799Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

