// This code is auto generated. Do not modify.

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class PieSix : IconParkIcon
{
    public PieSix()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(24, 24),
            Radius = 20
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M24 4C27.9556 4 31.8224 5.17298 35.1114 7.37061C38.4004 9.56824 40.9638 12.6918 42.4776 16.3463C43.9913 20.0009 44.3874 24.0222 43.6157 27.9018C42.844 31.7814 40.9392 35.3451 38.1421 38.1421C35.3451 40.9392 31.7814 42.844 27.9018 43.6157C24.0222 44.3874 20.0009 43.9913 16.3463 42.4776C12.6918 40.9638 9.56824 38.4004 7.37061 35.1114C5.17298 31.8224 4 27.9556 4 24H24V4Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

