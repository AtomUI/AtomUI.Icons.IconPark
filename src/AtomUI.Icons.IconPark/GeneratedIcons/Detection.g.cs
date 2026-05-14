// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Detection : IconParkIcon
{
    public Detection()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.9554799999999997, 6.3038400000000001, 38.808320000000002, 34.444859999999998);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.134075081440767, 0, 0, 1.134075081440767, -3.2178019545784053, -3.2178019545784053);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M6.45012 34.8494L10.4398 31.5017L10.9532 25.6319L18.9331 18.936L27.7107 11.5707L30.9026 8.8924C33.9875 6.30384 38.5867 6.70623 41.1753 9.79115C43.7638 12.8761 43.3615 17.4753 40.2765 20.0639L37.0847 22.7422L28.3071 30.1074L20.3272 36.8033L14.4598 36.2925L10.473 39.6379C9.14922 40.7487 7.17567 40.576 6.06492 39.2522C4.95548 37.9301 5.12794 35.9588 6.45012 34.8494Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M23.4365 9.71777L38.2075 27.3211"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M18.5755 29.0002L24.3018 24.0002"),
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

