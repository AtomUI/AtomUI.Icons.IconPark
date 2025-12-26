// This code is auto generated. Do not modify.
// Generated Date: 2025-12-26

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class HexagonStrip : IconParkIcon
{
    public HexagonStrip()
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
            Data = StreamGeometry.Parse("M19.0002 4H29.0002V15.3397L38.8207 9.66982L43.8207 18.3301L34.0002 24L43.8207 29.6698L38.8207 38.3301L29.0002 32.6602V44H19.0002V32.6602L9.17969 38.3301L4.17969 29.6698L14.0002 24L4.17969 18.3301L9.17969 9.66982L19.0002 15.3397V4Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

