// This code is auto generated. Do not modify.

using Avalonia;
using System;
using Avalonia.Media;
using AtomUI.Controls;
using AtomUI.Media;
namespace AtomUI.Icons.IconPark;

public class Symbol : IconParkIcon
{
    public Symbol()
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
            Data = StreamGeometry.Parse("M4 40.0032H18.0039C11.3346 35.6355 8 30.3009 8 23.9995C8 14.5473 15.0167 7.99976 24.0083 7.99976C33 7.99976 40 14.9998 40 23.9995C40 29.9993 36.6689 35.3338 30.0066 40.0032H44"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

