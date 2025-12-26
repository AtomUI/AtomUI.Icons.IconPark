// This code is auto generated. Do not modify.
// Generated Date: 2025-12-26

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class IwatchTwo : IconParkIcon
{
    public IwatchTwo()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M15.4167 10.5C18.2373 7.69936 21.9423 6 26 6C34.8366 6 42 14.0589 42 24C42 33.9411 34.8366 42 26 42C21.9423 42 18.2373 40.3006 15.4167 37.5"),
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(6, 10, 10, 28),
            RadiusX = 2,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = TransformParser.Parse("rotate(90 13 18)").Value,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Rect = new Rect(13, 18, 4, 4),
            RadiusX = 2,
            RadiusY = 0,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = TransformParser.Parse("rotate(90 13 25)").Value,
            FillBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Rect = new Rect(13, 25, 4, 4),
            RadiusX = 2,
            RadiusY = 0,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

