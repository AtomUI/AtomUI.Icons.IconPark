// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class Turkey : IconParkIcon
{
    public Turkey()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4, 4.0000032409255546, 40.293386759074451, 39.999996759074449);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.0982319708783626, 0, 0, 1.0982319708783626, -2.3575673010806995, -2.3575673010806995);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = true,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M4 36H44L39 44H9L4 36Z"),
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
            Data = StreamGeometry.Parse("M11 30.0001V36.0001H37L37 31.0001C37 25.0001 34 23.0001 34 23.0001C36 20.5001 37 17.0001 34 15.0001C31 13.0001 28.5 15.0001 27 17.0001C27 17.0001 11 15.0001 11 30.0001Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.SecondaryStroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M21 24C21 24 20 24.5 19 26C18 27.5 18 29 18 29"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M39 9C38.4667 9.64 35.4444 13.2667 34 15"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.81843362891017379, 0.57460107471960398, -0.57460107471960398, 0.81843362891017379, 11.26360951529621, -20.680639728969691),
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(38.3557, 7.48259),
            Radius = 2.5
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.81843362891017379, 0.57460107471960398, -0.57460107471960398, 0.81843362891017379, 12.699910667635725, -21.778346007383171),
            FillBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = false,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = false,
            Center = new Avalonia.Point(40.8108, 9.20646),
            Radius = 2.5
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

