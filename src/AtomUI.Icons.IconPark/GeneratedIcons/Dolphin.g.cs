// This code is auto generated. Do not modify.
// Generated Date: 2025-12-26

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class Dolphin : IconParkIcon
{
    public Dolphin()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

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
            Data = StreamGeometry.Parse("M24.0002 7.00002C14.2305 1.61313 9.68601 8.63202 8.00016 11.0004C2.33569 12.2184 5.14579 14.3237 7.00023 15.0004C8.21404 15.4064 11.1458 16.3233 13.0002 16.9999C13.4048 20.248 14.6631 23.1541 15.0002 23.9999C15.0002 23.1879 16.3259 20.3533 17.0002 18.9999C25.0923 22.248 30.7971 30.6015 34.0002 34.9999C32.7864 37.436 31.506 41.3082 31.0002 42.9999L37.0002 40L44.0002 42C44.0002 38.7519 39.8547 35.3534 38.0002 34C38.8095 21.0076 32.7091 13.1993 29.0002 11C29.4048 9.37598 30.1573 6.67671 31.0002 6.00002C27.7634 4.37598 25.1803 6.15418 24.0002 7.00002Z"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(16, 11),
            Radius = 2
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

