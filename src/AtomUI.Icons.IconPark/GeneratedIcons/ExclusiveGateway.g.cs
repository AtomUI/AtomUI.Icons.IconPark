// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class ExclusiveGateway : IconParkIcon
{
    public ExclusiveGateway()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(3.6333500000000001, 3.4199700000000002, 41.160049999999998, 41.160029999999999);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0818934758667882, 0, 0, 1.0818934758667882, -1.9654434208029166, -1.9654434208029166);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M22.7992 4.20102L4.4144 22.5858C3.63336 23.3668 3.63335 24.6332 4.4144 25.4142L22.7992 43.799C23.5802 44.58 24.8466 44.58 25.6276 43.799L44.0124 25.4142C44.7934 24.6332 44.7934 23.3668 44.0124 22.5858L25.6276 4.20102C24.8466 3.41997 23.5802 3.41997 22.7992 4.20102Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M18.043 29.9871L30.0427 18.0249"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M18.0527 18.0156L30.0337 29.9965"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

