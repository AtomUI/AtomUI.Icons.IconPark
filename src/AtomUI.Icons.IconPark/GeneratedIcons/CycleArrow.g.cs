// This code is auto generated. Do not modify.
// Generated Date: 2025-12-02

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class CycleArrow : IconParkIcon
{
    public CycleArrow()
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
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M17 16H13C8.02944 16 4 20.0294 4 25C4 29.9706 8.02944 34 13 34C15.4758 34 17.7181 33.0003 19.3453 31.3826C20.9849 29.7525 24 25 24 25C24 25 27.0057 20.2685 28.632 18.6401C30.261 17.009 32.5127 16 35 16C39.9706 16 44 20.0294 44 25C44 29.9706 39.9706 34 35 34H31"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M35 30L31 34L35 38"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M13 12L17 16L13 20"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

