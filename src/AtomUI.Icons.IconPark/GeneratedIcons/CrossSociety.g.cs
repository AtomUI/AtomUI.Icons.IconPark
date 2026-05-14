// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class CrossSociety : IconParkIcon
{
    public CrossSociety()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(5, 5, 38, 38);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1162790697674418, 0, 0, 1.1162790697674418, -2.7906976744186025, -2.7906976744186025);

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
            Data = StreamGeometry.Parse("M7 18H18V7C18 5.89543 18.8954 5 20 5H28C29.1046 5 30 5.89543 30 7V18H41C42.1046 18 43 18.8954 43 20V28C43 29.1046 42.1046 30 41 30H30V41C30 42.1046 29.1046 43 28 43H20C18.8954 43 18 42.1046 18 41V30H7C5.89543 30 5 29.1046 5 28V20C5 18.8954 5.89543 18 7 18Z"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

