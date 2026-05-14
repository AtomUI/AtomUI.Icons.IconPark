using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using AtomUI.Controls;
using AtomUI.Media;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Headless;
using Avalonia.Media;
using System.Globalization;

namespace AtomUI.Icons.IconPark.Generator;

public class IconParkIconsPackageGenerator : DefaultIconPackageGenerator
{
    private static readonly JsonSerializerOptions StringLiteralJsonSerializerOptions = new()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
    };

    private string _configFilePath;
    public IconParkIconsPackageGenerator(string sourcePath, string targetPath)
        : base(sourcePath, targetPath)
    {
        PackageName              = "IconPark";
        PackageNamespace         = "AtomUI.Icons.IconPark";
        _configFilePath = Path.Combine(Path.Combine(sourcePath, "source"), "icons-config.json");
    }
    
    public static async Task<int> Main(string[] args)
    {
        try
        {
            SetupAvalonia();
            var targetProjectPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../src/AtomUI.Icons.IconPark"));
            var sourceProjectPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../iconpark"));
            var generator         = new IconParkIconsPackageGenerator(sourceProjectPath, targetProjectPath);
            await generator.GenerateAsync();
            return 0;
        }
        catch  (Exception e)
        {
            await Console.Error.WriteLineAsync($"Generate error: {e.Message}");
#if DEBUG
            throw;
#endif
            return 1;
        }
    }

    private static void SetupAvalonia()
    {
        AppBuilder.Configure<GeneratorApplication>()
                  .UseHeadless(new AvaloniaHeadlessPlatformOptions())
                  .SetupWithLifetime(new ClassicDesktopStyleApplicationLifetime());
        SynchronizationContext.SetSynchronizationContext(null);
    }

    protected override void PrepareEnvironment()
    {
        base.PrepareEnvironment();
        if (!File.Exists(_configFilePath))
        {
            throw new FileNotFoundException($"config file not found: {_configFilePath}");
        }
    }

    protected override IEnumerable<IconFileInfo> ScanIconFilesRecursively(string sourcePath)
    {
        using var fileStream = File.OpenRead(_configFilePath);
        using var jsonDocument = JsonDocument.Parse(fileStream);
        var iconSvgFilePath = Path.Combine(Path.Combine(Path.Combine(Path.Combine(sourcePath, "packages"), "react"), "src"), "icons");
        foreach (var element in jsonDocument.RootElement.EnumerateArray())
        {
            var item = JsonSerializer.Deserialize<IconMetaInfo>(element.GetRawText(), new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            });
            if (item != null)
            {
                var name = NormalizeIconName(item.Name);
                yield return new IconFileInfo()
                {
                    Name = name,
                    Category = item.Category,
                    FilePath = $"{Path.Combine(iconSvgFilePath, name)}.tsx",
                };
            }
        }
    }

    private static string NormalizeIconName(string baseName)
    {
        var name = CapitalizeFirstLetter(baseName);
        name = Regex.Replace(name, @"[-_]([a-zA-Z0-9])",
            match => match.Groups[1].ToString().ToUpper());
        return name;
    }
    
    private static string CapitalizeFirstLetter(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return str;
        }
        return char.ToUpper(str[0]) + str.Substring(1);
    }
    
    protected override string GenerateIconClassFileName(IconFileInfo iconFileInfo)
    {
        return Path.Combine(GeneratedIconsPath, $"{iconFileInfo.Name}.g.cs");
    }

    protected override async Task GenerateIconPackageClass(IconFileInfo iconFileInfo, Stream output)
    {
        var sourceText = new StringBuilder();
        sourceText.AppendLine("// This code is auto generated. Do not modify.");
        sourceText.AppendLine("");
        sourceText.AppendLine("using System.Collections.Generic;");
        sourceText.AppendLine("using Avalonia;");
        sourceText.AppendLine("using Avalonia.Media;");
        sourceText.AppendLine("using AtomUI.Controls;");
        sourceText.AppendLine($"namespace {PackageNamespace};");
        sourceText.AppendLine("");
        var svgSource     = await File.ReadAllTextAsync(iconFileInfo.FilePath);
        var match = Regex.Matches(svgSource, @"<svg\b[^>]*>([\s\S]*?)<\/svg>");
        svgSource = match.First().Value;
        svgSource = svgSource.Replace("{{", "{");
        svgSource = svgSource.Replace("}}", "}");
        svgSource = svgSource.Replace("{", "\"{");
        svgSource = svgSource.Replace("}", "}\"");
        svgSource = svgSource.Replace("strokeWidth", "stroke-width");
        svgSource = svgSource.Replace("strokeLinecap", "stroke-linecap");
        svgSource = svgSource.Replace("strokeLinejoin", "stroke-linejoin");
        var    svgParsedInfo = SvgParser.Parse(svgSource);
        var    viewBox       = svgParsedInfo.ViewBox;
        var    viewBoxRect   = new Rect(viewBox.X, viewBox.Y, viewBox.Width, viewBox.Height);
        var    geometryBounds = CalculateGeometryBounds(svgParsedInfo);
        var    zoomMatrix     = CalculateZoomToFit(viewBoxRect, geometryBounds);
        var    className     = $"{iconFileInfo.Name}";
        sourceText.AppendLine($"public class {className} : IconParkIcon");
        sourceText.AppendLine(@"{");
        sourceText.AppendLine($"    public {className}()");
        sourceText.AppendLine(@"    {");
        sourceText.AppendLine($"        IconTheme = IconThemeType.Filled;");
        sourceText.AppendLine($"        ViewBox = {FormatRect(viewBoxRect)};");
        sourceText.AppendLine(@"    }");
        sourceText.AppendLine(@"");
        sourceText.AppendLine(@"    internal override bool HasGeneratedGeometryMetadata => true;");
        sourceText.AppendLine($"    internal override Rect GeneratedViewBox => {FormatRect(viewBoxRect)};");
        sourceText.AppendLine($"    internal override Rect GeneratedGeometryBounds => {FormatRect(geometryBounds)};");
        sourceText.AppendLine($"    internal override Matrix GeneratedZoomMatrix => {FormatMatrix(zoomMatrix)};");
        sourceText.AppendLine(@"");
        sourceText.AppendLine(@"    private static readonly DrawingInstruction[] StaticInstructions = [");
        var graphicElementCount = svgParsedInfo.GraphicElements.Count;
        var effectiveGraphicElementCount = graphicElementCount;
        
        for (var i = 0; i < graphicElementCount; i++)
        {
            var graphicElement  = svgParsedInfo.GraphicElements[i];
            if (graphicElement.FillColor == "none")
            {
                --effectiveGraphicElementCount;
            }
        }
        
        for (var i = 0; i < graphicElementCount; i++)
        {
            var graphicElement  = svgParsedInfo.GraphicElements[i];
            if (graphicElement.FillColor == "none")
            {
                continue;
            }
            if (graphicElement is RectElement rectElement)
            {
                sourceText.AppendLine(@"        new RectDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(rectElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Rect = new Rect({rectElement.X}, {rectElement.Y}, {rectElement.Width}, {rectElement.Height}),");
                sourceText.AppendLine($"            RadiusX = {rectElement.RadiusX},");
                sourceText.AppendLine($"            RadiusY = {rectElement.RadiusY},");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is CircleElement circleElement)
            {
                sourceText.AppendLine(@"        new CircleDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(circleElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Center = new Avalonia.Point({circleElement.CenterX}, {circleElement.CenterY}),");
                sourceText.AppendLine($"            Radius = {circleElement.Radius}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is EllipseElement ellipseElement)
            {
                sourceText.AppendLine(@"        new EllipseDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(ellipseElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Center = new Avalonia.Point({ellipseElement.CenterX}, {ellipseElement.CenterY}),");
                sourceText.AppendLine($"            RadiusX = {ellipseElement.RadiusX},");
                sourceText.AppendLine($"            RadiusY = {ellipseElement.RadiusY}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is LineElement lineElement)
            {
                sourceText.AppendLine(@"        new LineDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(lineElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            StartPoint = new Avalonia.Point({lineElement.X1}, {lineElement.Y1}),");
                sourceText.AppendLine($"            EndPoint = new Avalonia.Point({lineElement.X2}, {lineElement.Y2}),");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is PolygonElement polygonElement)
            {
                var points = new List<string>();
                foreach (var point in polygonElement.Points)
                {
                    points.Add($"new Avalonia.Point({point.X}, {point.Y})");
                }
                sourceText.AppendLine(@"        new PolygonDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(polygonElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Points = [{string.Join(',', points)}]");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is PolylineElement polylineElement)
            {
                var points = new List<string>();
                foreach (var point in polylineElement.Points)
                {
                    points.Add($"new Avalonia.Point({point.X}, {point.Y})");
                }
                sourceText.AppendLine(@"        new PolylineDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(polylineElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Points = [{string.Join(',', points)}]");
                sourceText.AppendLine(@"        },");
            }
            if (graphicElement is PathElement pathElement)
            {
                sourceText.AppendLine(@"        new PathDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(pathElement, effectiveGraphicElementCount, sourceText);
                sourceText.AppendLine($"            Data = StreamGeometry.Parse(\"{pathElement.Data}\"),");
                sourceText.AppendLine(@"        },");
            }
        }
        sourceText.AppendLine(@"    ];");
        sourceText.AppendLine(@"");
        sourceText.AppendLine(@"    protected override IList<DrawingInstruction> DrawingInstructions => StaticInstructions;");
        sourceText.AppendLine("}");
        sourceText.AppendLine("");
        
        await output.WriteAsync(Encoding.UTF8.GetBytes(sourceText.ToString()));
    }
    
    protected override async Task GenerateIconPackageClassesAsync()
    {
        await base.GenerateIconPackageClassesAsync();
        await GenerateIconRepositoryClassAsync();
    }

    private async Task GenerateIconRepositoryClassAsync()
    {
         var repoClsFilePath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../gallery/IconParkGallery/Models/IconMetaInfoRepository.g.cs"));
        if (File.Exists(repoClsFilePath))
        {
            File.Delete(repoClsFilePath);
        }
        await using var stream = new FileStream(repoClsFilePath, FileMode.Create, FileAccess.Write);
        var sourceText = new StringBuilder();
        sourceText.AppendLine("// This code is auto generated. Do not modify.");
        sourceText.AppendLine($"// Generated Date: {DateTime.Today.ToString("yyyy-MM-dd")}");
        sourceText.AppendLine("#nullable enable");
        sourceText.AppendLine("");
        sourceText.AppendLine("using System.Collections.Generic;");
        sourceText.AppendLine("using AtomUI.Controls;");
        sourceText.AppendLine("using AtomUI.Icons.IconPark;");
        sourceText.AppendLine($"namespace IconParkGallery.Models;");
        
        sourceText.AppendLine("");
        
        sourceText.AppendLine($"public partial class IconMetaInfoRepository");
        sourceText.AppendLine(@"{");
        sourceText.AppendLine(@"    public IconMetaInfoRepository()");
        sourceText.AppendLine(@"    {");
        
        await using var fileStream = File.OpenRead(_configFilePath);
        using var jsonDocument = await JsonDocument.ParseAsync(fileStream);
        
        var iconMetaInfos = new List<IconMetaInfo>();
        
        foreach (var element in jsonDocument.RootElement.EnumerateArray())
        {
            var item = JsonSerializer.Deserialize<IconMetaInfo>(element.GetRawText(), new JsonSerializerOptions()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                PropertyNameCaseInsensitive = true,
                NumberHandling = JsonNumberHandling.AllowReadingFromString
            });
            if (item != null)
            {
                item.Name = NormalizeIconName(item.Name);
                item.Title = item.Title.Trim();
                iconMetaInfos.Add(item);
            }
        }

        var categoryGroups = iconMetaInfos
            .GroupBy(item => item.Category)
            .OrderBy(group => group.Key)
            .ToList();
        var categories = categoryGroups.Select(group => group.Key);
        sourceText.AppendLine(@"        Categories = [");
        foreach (var category in categories)
        {
            sourceText.AppendLine($"            {StringLiteral(category)},");
        }
        sourceText.AppendLine(@"        ];");
        sourceText.AppendLine(@"    }");
        sourceText.AppendLine("");
        sourceText.AppendLine(@"    protected partial List<IconMetaInfo> CreateIconInfos(string? category, IconThemeType iconTheme)");
        sourceText.AppendLine(@"    {");
        sourceText.AppendLine(@"        return category switch");
        sourceText.AppendLine(@"        {");
        foreach (var categoryGroup in categoryGroups)
        {
            var categoryName = categoryGroup.Key;
            sourceText.AppendLine($"            {StringLiteral(categoryName)} => Create{ToIdentifierPart(categoryName)}IconInfos(iconTheme),");
        }
        sourceText.AppendLine(@"            _ => []");
        sourceText.AppendLine(@"        };");
        sourceText.AppendLine(@"    }");

        foreach (var categoryGroup in categoryGroups)
        {
            var categoryIdentifier = ToIdentifierPart(categoryGroup.Key);
            sourceText.AppendLine("");
            sourceText.AppendLine($"    private static List<IconMetaInfo> Create{categoryIdentifier}IconInfos(IconThemeType iconTheme)");
            sourceText.AppendLine(@"    {");
            sourceText.AppendLine(@"        return [");
            foreach (var iconMetaInfo in categoryGroup)
            {
                AppendIconMetaInfo(sourceText, iconMetaInfo);
            }
            sourceText.AppendLine(@"        ];");
            sourceText.AppendLine(@"    }");
        }
        sourceText.AppendLine(@"}");
        await stream.WriteAsync(Encoding.UTF8.GetBytes(sourceText.ToString()));
    }

    private static void AppendIconMetaInfo(StringBuilder sourceText, IconMetaInfo iconMetaInfo)
    {
        var rtl = iconMetaInfo.Rtl ? "true" : "false";
        var tags = string.Join(", ", iconMetaInfo.Tags.Select(StringLiteral));
        sourceText.AppendLine(@"            new IconMetaInfo {");
        sourceText.AppendLine($"                Id = {iconMetaInfo.Id},");
        sourceText.AppendLine($"                Title = {StringLiteral(iconMetaInfo.Title)},");
        sourceText.AppendLine($"                Name = {StringLiteral(iconMetaInfo.Name)},");
        sourceText.AppendLine($"                Author = {StringLiteral(iconMetaInfo.Author)},");
        sourceText.AppendLine($"                Category = {StringLiteral(iconMetaInfo.Category)},");
        sourceText.AppendLine($"                CategoryCN = {StringLiteral(iconMetaInfo.CategoryCN)},");
        sourceText.AppendLine($"                Tags = [{tags}],");
        sourceText.AppendLine($"                Rtl = {rtl},");
        sourceText.AppendLine($"                IconType = typeof(AtomUI.Icons.IconPark.{iconMetaInfo.Name}),");
        sourceText.AppendLine(@"                Creator = () =>");
        sourceText.AppendLine(@"                {");
        sourceText.AppendLine($"                    var icon = new AtomUI.Icons.IconPark.{iconMetaInfo.Name}();");
        sourceText.AppendLine(@"                    icon.IconTheme = iconTheme;");
        sourceText.AppendLine(@"                    return icon;");
        sourceText.AppendLine(@"                }");
        sourceText.AppendLine(@"            },");
    }

    private static string StringLiteral(string value)
    {
        return JsonSerializer.Serialize(value, StringLiteralJsonSerializerOptions);
    }

    private static string ToIdentifierPart(string value)
    {
        return Regex.Replace(value, @"[^a-zA-Z0-9_]", string.Empty);
    }

    private static Rect CalculateGeometryBounds(SvgParsedInfo svgParsedInfo)
    {
        var group = new GeometryGroup();
        foreach (var graphicElement in svgParsedInfo.GraphicElements)
        {
            if (graphicElement.FillColor == "none")
            {
                continue;
            }

            var geometry = BuildGeometry(graphicElement);
            if (geometry is null)
            {
                continue;
            }

            if (!string.IsNullOrEmpty(graphicElement.Transform))
            {
                geometry.Transform = new MatrixTransform(TransformParser.Parse(graphicElement.Transform).Value);
            }

            group.Children.Add(geometry);
        }

        return group.Bounds;
    }

    private static Geometry? BuildGeometry(SvgGraphicElement graphicElement)
    {
        return graphicElement switch
        {
            RectElement rectElement => new RectangleGeometry(
                new Rect(rectElement.X, rectElement.Y, rectElement.Width, rectElement.Height),
                rectElement.RadiusX,
                rectElement.RadiusY),
            CircleElement circleElement => new EllipseGeometry
            {
                Center  = new Avalonia.Point(circleElement.CenterX, circleElement.CenterY),
                RadiusX = circleElement.Radius,
                RadiusY = circleElement.Radius
            },
            EllipseElement ellipseElement => new EllipseGeometry
            {
                Center  = new Avalonia.Point(ellipseElement.CenterX, ellipseElement.CenterY),
                RadiusX = ellipseElement.RadiusX,
                RadiusY = ellipseElement.RadiusY
            },
            LineElement lineElement => new LineGeometry
            {
                StartPoint = new Avalonia.Point(lineElement.X1, lineElement.Y1),
                EndPoint   = new Avalonia.Point(lineElement.X2, lineElement.Y2)
            },
            PolygonElement polygonElement => new PolylineGeometry
            {
                Points   = polygonElement.Points.Select(point => new Avalonia.Point(point.X, point.Y)).ToArray(),
                IsFilled = true
            },
            PolylineElement polylineElement => new PolylineGeometry
            {
                Points   = polylineElement.Points.Select(point => new Avalonia.Point(point.X, point.Y)).ToArray(),
                IsFilled = false
            },
            PathElement pathElement when !string.IsNullOrEmpty(pathElement.Data) => StreamGeometry.Parse(pathElement.Data),
            _ => null
        };
    }

    private static Matrix CalculateZoomToFit(Rect viewbox, Rect iconBounds)
    {
        var viewboxCenter = new Avalonia.Point(
            viewbox.Left + viewbox.Width / 2,
            viewbox.Top + viewbox.Height / 2
        );

        var leftDelta   = iconBounds.Left - viewbox.Left;
        var rightDelta  = viewbox.Right - iconBounds.Right;
        var topDelta    = iconBounds.Top - viewbox.Top;
        var bottomDelta = viewbox.Bottom - iconBounds.Bottom;

        var minDelta = leftDelta;
        if (rightDelta < minDelta)
        {
            minDelta = rightDelta;
        }

        if (topDelta < minDelta)
        {
            minDelta = topDelta;
        }

        if (bottomDelta < minDelta)
        {
            minDelta = bottomDelta;
        }

        minDelta /= 2;

        var iconLeftDist   = iconBounds.Left - viewboxCenter.X - minDelta;
        var iconRightDist  = iconBounds.Right - viewboxCenter.X - minDelta;
        var iconTopDist    = iconBounds.Top - viewboxCenter.Y - minDelta;
        var iconBottomDist = iconBounds.Bottom - viewboxCenter.Y - minDelta;

        var viewboxLeftDist   = viewbox.Left - viewboxCenter.X;
        var viewboxRightDist  = viewbox.Right - viewboxCenter.X;
        var viewboxTopDist    = viewbox.Top - viewboxCenter.Y;
        var viewboxBottomDist = viewbox.Bottom - viewboxCenter.Y;

        var maxScale = double.MaxValue;

        if (Math.Abs(iconLeftDist) > 0.0001)
        {
            var scaleLeft = viewboxLeftDist / iconLeftDist;
            if (scaleLeft > 0 && scaleLeft < maxScale)
            {
                maxScale = scaleLeft;
            }
        }

        if (Math.Abs(iconRightDist) > 0.0001)
        {
            var scaleRight = viewboxRightDist / iconRightDist;
            if (scaleRight > 0 && scaleRight < maxScale)
            {
                maxScale = scaleRight;
            }
        }

        if (Math.Abs(iconTopDist) > 0.0001)
        {
            var scaleTop = viewboxTopDist / iconTopDist;
            if (scaleTop > 0 && scaleTop < maxScale)
            {
                maxScale = scaleTop;
            }
        }

        if (Math.Abs(iconBottomDist) > 0.0001)
        {
            var scaleBottom = viewboxBottomDist / iconBottomDist;
            if (scaleBottom > 0 && scaleBottom < maxScale)
            {
                maxScale = scaleBottom;
            }
        }

        if (maxScale > 1000 || maxScale <= 0)
        {
            maxScale = 1.0;
        }

        var transform = Matrix.Identity;
        transform *= Matrix.CreateTranslation(-viewboxCenter.X, -viewboxCenter.Y);
        transform *= Matrix.CreateScale(maxScale, maxScale);
        transform *= Matrix.CreateTranslation(viewboxCenter.X, viewboxCenter.Y);

        return transform;
    }

    private static string FormatRect(Rect rect)
    {
        return $"new Rect({FormatDouble(rect.X)}, {FormatDouble(rect.Y)}, {FormatDouble(rect.Width)}, {FormatDouble(rect.Height)})";
    }

    private static string FormatMatrix(Matrix matrix)
    {
        return $"new Matrix({FormatDouble(matrix.M11)}, {FormatDouble(matrix.M12)}, {FormatDouble(matrix.M21)}, {FormatDouble(matrix.M22)}, {FormatDouble(matrix.M31)}, {FormatDouble(matrix.M32)})";
    }

    private static string FormatDouble(double value)
    {
        if (Math.Abs(value) < 1e-12)
        {
            value = 0;
        }

        return value.ToString("G17", CultureInfo.InvariantCulture);
    }

    private void GenerateCommonCode(SvgGraphicElement graphicElement, int graphicElementCount, StringBuilder output)
    {
        output.AppendLine($"            Opacity = {graphicElement.Opacity},");
        if (!string.IsNullOrEmpty(graphicElement.Transform))
        {
            output.AppendLine($"            Transform = {FormatMatrix(TransformParser.Parse(graphicElement.Transform).Value)},");
        }
        if (!string.IsNullOrEmpty(graphicElement.FillColor))
        {
            var fillIndex = graphicElement.FillColor.Length > 0 ? graphicElement.FillColor[^3] - '0' : -1;
            output.AppendLine($"            FillBrush = IconBrushType.{GetBrushTypeByIndex(fillIndex)},");
        }
        if (!string.IsNullOrEmpty(graphicElement.StrokeColor))
        {
            var fillIndex = graphicElement.StrokeColor.Length > 0 ? graphicElement.StrokeColor[^3] - '0' : -1;
            output.AppendLine($"            StrokeBrush = IconBrushType.{GetBrushTypeByIndex(fillIndex)},");
        }

        var hasStrokeWidth = !string.IsNullOrEmpty(graphicElement.StrokeWidth);
        var hasStrokeLineCap = !string.IsNullOrEmpty(graphicElement.StrokeLineCap);
        var hasStrokeLineJoin = !string.IsNullOrEmpty(graphicElement.StrokeLineJoin);
        
        if (hasStrokeWidth)
        {
            output.AppendLine($"            IsStrokeWidthCustomizable = true,");
        }
        else
        {
            output.AppendLine($"            IsStrokeWidthCustomizable = false,");
        }
        
        if (hasStrokeLineCap)
        {
            output.AppendLine($"            IsStrokeLinecapCustomizable = true,");
        }
        else
        {
            output.AppendLine($"            IsStrokeLinecapCustomizable = false,");
        }
        
        if (hasStrokeLineJoin)
        {
            output.AppendLine($"            IsStrokeLinejoinCustomizable = true,");
        }
        else
        {
            output.AppendLine($"            IsStrokeLinejoinCustomizable = false,");
        }
        
        if (hasStrokeWidth || hasStrokeLineCap || hasStrokeLineJoin)
        {
            output.AppendLine($"            IsStrokeEnabled = true,");
        }
        else
        {
            output.AppendLine($"            IsStrokeEnabled = false,");
        }
    }

    private IconBrushType GetBrushTypeByIndex(int index)
    {
        return index switch
        {
            0 => IconBrushType.Stroke,
            1 => IconBrushType.Fill,
            2 => IconBrushType.SecondaryStroke,
            3 => IconBrushType.SecondaryFill,
            _ => IconBrushType.Fallback
        };
    }
    
    protected override async Task GenerateIconPackageKindAsync()
    {
        await using var output = new FileStream(Path.Combine(GeneratedIconsPath, $"{PackageName}IconKind.g.cs"), FileMode.Create, FileAccess.Write);
        var sourceText  = new StringBuilder();
        sourceText.AppendLine("///");
        sourceText.AppendLine("/// This code is auto generated. Do not amend.");
        sourceText.AppendLine("///");
        sourceText.AppendLine($"namespace {PackageNamespace};");
        sourceText.AppendLine($"public enum {PackageName}IconKind");
        sourceText.AppendLine("{");
        for (var i = 0; i < IconFiles.Count; ++i)
        {
            var info = IconFiles[i];
            sourceText.AppendLine($"    {info.Name} = {i + 1},");
        }
        
        sourceText.AppendLine("}");
        await output.WriteAsync(Encoding.UTF8.GetBytes(sourceText.ToString()));
    }

    private sealed class GeneratorApplication : Avalonia.Application;
}
