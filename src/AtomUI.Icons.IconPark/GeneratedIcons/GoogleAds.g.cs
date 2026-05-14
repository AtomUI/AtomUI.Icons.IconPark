// This code is auto generated. Do not modify.

using System.Collections.Generic;
using Avalonia;
using Avalonia.Media;
using AtomUI.Controls;
namespace AtomUI.Icons.IconPark;

public class GoogleAds : IconParkIcon
{
    public GoogleAds()
    {
        IconTheme = IconThemeType.Filled;
        ViewBox = new Rect(0, 0, 48, 48);
    }

    internal override bool HasGeneratedGeometryMetadata => true;
    internal override Rect GeneratedViewBox => new Rect(0, 0, 48, 48);
    internal override Rect GeneratedGeometryBounds => new Rect(4.1092437073359029, 4.4735199999999997, 38.646256292664091, 40.188236292664094);
    internal override Matrix GeneratedZoomMatrix => new Matrix(1.1131788332525008, 0, 0, 1.1131788332525008, -2.7162919980600186, -2.7162919980600186);

    private static readonly DrawingInstruction[] StaticInstructions = [
        new PathDrawingInstruction()
        {
            Opacity = 1,
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M41.3551 34.1527L29.5218 8.7761C28.1213 5.77286 24.5514 4.47352 21.5482 5.87396C18.545 7.27439 17.2456 10.8443 18.6461 13.8475L30.4794 39.2241C31.8798 42.2274 35.4497 43.5267 38.4529 42.1263C41.4562 40.7258 42.7555 37.156 41.3551 34.1527Z"),
        },
        new PathDrawingInstruction()
        {
            Opacity = 1,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = true,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Data = StreamGeometry.Parse("M23.4375 26.5357L17.5209 39.224C16.1204 42.2273 12.5506 43.5266 9.54731 42.1262V42.1262C6.54407 40.7257 5.24474 37.1558 6.64517 34.1526L18.374 9"),
        },
        new CircleDrawingInstruction()
        {
            Opacity = 1,
            Transform = new Matrix(0.90630778703664994, 0.42261826174069944, -0.42261826174069944, 0.90630778703664994, 16.637167581188695, -1.6690132853185435),
            FillBrush = IconBrushType.Fill,
            StrokeBrush = IconBrushType.Stroke,
            IsStrokeWidthCustomizable = true,
            IsStrokeLinecapCustomizable = false,
            IsStrokeLinejoinCustomizable = false,
            IsStrokeEnabled = true,
            Center = new Avalonia.Point(12.0828, 36.6882),
            Radius = 6
        },
    ];

    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;
}

