// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Fan : IconParkIcon
{
    public Fan()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.0273399999999997, 10, 39.944359999999996, 26);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0915873636027476, 0, 0, 1.0915873636027476, -2.1980967264659412, -2.1980967264659412);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M23.9995 31V36M14.0134 27.7553L4.02734 24.5106C5.39776 20.2929 8.06824 16.6173 11.656 14.0106C15.2438 11.404 19.5648 10 23.9995 10C28.4343 10 32.7552 11.404 36.343 14.0106C39.9308 16.6173 42.6013 20.2929 43.9717 24.5106L33.9856 27.7553H14.0134ZM14.0134 27.7553C14.6986 25.6465 16.0339 23.8087 17.8278 22.5053L14.0134 27.7553ZM14.0134 27.7553L23.9995 31L14.0134 27.7553ZM17.8278 22.5053C19.6217 21.202 21.7821 20.5 23.9995 20.5L17.8278 22.5053ZM17.8278 22.5053L23.9995 31L17.8278 22.5053ZM23.9995 20.5C26.2169 20.5 28.3774 21.202 30.1713 22.5053L23.9995 20.5ZM23.9995 20.5V31V20.5ZM30.1713 22.5053C31.9652 23.8087 33.3004 25.6465 33.9856 27.7553L30.1713 22.5053ZM30.1713 22.5053L23.9995 31L30.1713 22.5053ZM33.9856 27.7553L23.9995 31L33.9856 27.7553Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

