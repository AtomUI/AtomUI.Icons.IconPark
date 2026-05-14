// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class TwoHands : IconParkIcon
{
    public TwoHands()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.0123199999999999, 6.0290999999999997, 39.996879999999997, 36.098700000000001);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0917487449438386, 0, 0, 1.0917487449438386, -2.2019698786521253, -2.2019698786521253);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M36.9997 19.9756L36.0171 23.9332L27.3113 30.2402L27.3613 41.9575L33.9997 42.0001L33.627 33.5146C40.5485 29.1858 44.0092 26.0143 44.0092 24.0001C44.0092 21.9859 44.0092 16.6721 44.0092 6.05867"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M10.9997 20.0509L12.0329 24.0002L20.4003 30.4158L20.7592 42.1278L13.9997 42.0002L14.2027 33.9086C7.4091 30.0008 4.01232 27.025 4.01232 24.9811C4.01232 22.9373 4.01232 17.2866 4.01232 6.0291"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

