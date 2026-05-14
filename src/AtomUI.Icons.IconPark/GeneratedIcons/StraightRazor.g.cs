// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class StraightRazor : IconParkIcon
{
    public StraightRazor()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(3.6093799999999998, 4, 40.390619999999998, 38.44254651807325);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0813095198940677, 0, 0, 1.0813095198940677, -1.9514284774576254, -1.9514284774576254);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.98480775301220802, -0.17364817766693033, 0.17364817766693033, 0.98480775301220802, -6.2891758359975363, 1.1817912532853609),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(3.60938, 36.5337, 38, 6),
            RadiusX = 2,
            RadiusY = 2,
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M44 40L40 36"),
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
            Data = StreamGeometry.Parse("M8 4L26.3848 22.3848L22.1421 26.6274C22.1421 26.6274 12.2426 16.7279 9.41419 13.8995C6.58577 11.071 6.58575 9.65682 6.58577 8.24262C6.58579 6.82843 8 4 8 4Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M8 4L26 22L35 31"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

