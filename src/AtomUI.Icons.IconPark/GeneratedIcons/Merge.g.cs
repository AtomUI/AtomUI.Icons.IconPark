// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Merge : IconParkIcon
{
    public Merge()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.0000000000000018, 9.857864376269049, 40.284271247461902, 29.698484809834994);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0980029698627216, 0, 0, 1.0980029698627216, -2.3520712767053169, -2.3520712767053169);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, -0.70710678118654746, 0.70710678118654746, 0.70710678118654757, -15.798989873223329, 9.857864376269049),
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(4, 24, 20, 22),
            RadiusX = 2,
            RadiusY = 2,
        },
        new RectDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.70710678118654757, -0.70710678118654746, 0.70710678118654746, 0.70710678118654757, -12.2842712474619, 18.343145750507617),
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Rect = new Rect(16, 24, 20, 20),
            RadiusX = 2,
            RadiusY = 2,
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

