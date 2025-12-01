using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using AtomUI.Controls;

namespace AtomUI.Icons.IconPark.Generator;

public class IconParkIconsPackageGenerator : DefaultIconPackageGenerator
{
    public IconParkIconsPackageGenerator(string sourcePath, string targetPath)
        : base(sourcePath, targetPath)
    {
        PackageName              = "IconPark";
        PackageNamespace         = "AtomUI.Icons.IconPark";
    }
    
    public static async Task<int> Main(string[] args)
    {
        try
        {
            var targetProjectPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../src/AtomUI.Icons.IconPark"));
            var sourceProjectPath = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "../../../../iconpark"));
            var generator         = new IconParkIconsPackageGenerator(sourceProjectPath, targetProjectPath);
            await generator.GenerateAsync();
            return 0;
        }
        catch  (Exception e)
        {
            Console.Error.WriteLine($"Generate error: {e.Message}");
#if DEBUG
            throw;
#endif
            return 1;
        }
    }

    protected override IEnumerable<IconFileInfo> ScanIconFilesRecursively(string sourcePath)
    {
        var configFilePath = Path.Combine(Path.Combine(sourcePath, "source"), "icons-config.json");
        if (!File.Exists(configFilePath))
        {
            throw new FileNotFoundException($"config file not found: {configFilePath}");
        }
        using var fileStream = File.OpenRead(configFilePath);
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

    private string NormalizeIconName(string baseName)
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
        sourceText.AppendLine($"// Generated Date: {DateTime.Today.ToString("yyyy-MM-dd")}");
        sourceText.AppendLine("");
        sourceText.AppendLine("using Avalonia;");
        sourceText.AppendLine("using System;");
        sourceText.AppendLine("using Avalonia.Media;");
        sourceText.AppendLine("using AtomUI.Controls;");
        sourceText.AppendLine("using AtomUI.Media;");
        sourceText.AppendLine($"namespace {PackageNamespace};");
        sourceText.AppendLine("");
        var svgSource     = await File.ReadAllTextAsync(iconFileInfo.FilePath);
        var match = Regex.Matches(svgSource, @"<svg\b[^>]*>([\s\S]*?)<\/svg>");
        svgSource = match.First().Value;
        svgSource = svgSource.Replace("{{", "{");
        svgSource = svgSource.Replace("}}", "}");
        svgSource = svgSource.Replace("{", "\"{");
        svgSource = svgSource.Replace("}", "}\"");
        svgSource = svgSource.Replace("strokeWith", "stroke-width");
        svgSource = svgSource.Replace("strokeLinecap", "stroke-linecap");
        svgSource = svgSource.Replace("strokeLinejoin", "stroke-linejoin");
        var    svgParsedInfo = SvgParser.Parse(svgSource);
        var    viewBox       = svgParsedInfo.ViewBox;
        var    className     = $"{iconFileInfo.Name}";
        sourceText.AppendLine($"public class {className} : Icon");
        sourceText.AppendLine(@"{");
        sourceText.AppendLine($"    public {className}()");
        sourceText.AppendLine(@"    {");
        sourceText.AppendLine($"        IconTheme = IconThemeType.Filled;");
        sourceText.AppendLine($"        ViewBox = new Rect({viewBox.X}, {viewBox.Y}, {viewBox.Width}, {viewBox.Height});");
        sourceText.AppendLine(@"    }");
        sourceText.AppendLine(@"");
        sourceText.AppendLine(@"    private static readonly DrawingInstruction[] StaticInstructions = [");
        for (var i = 0; i < svgParsedInfo.GraphicElements.Count; i++)
        {
            var graphicElement  = svgParsedInfo.GraphicElements[i];
            if (graphicElement is RectElement rectElement)
            {
                sourceText.AppendLine(@"        new RectDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(rectElement, sourceText);
                sourceText.AppendLine($"            Rect = new Rect({rectElement.X}, {rectElement.Y}, {rectElement.Width}, {rectElement.Height}),");
                sourceText.AppendLine($"            RadiusX = {rectElement.RadiusX},");
                sourceText.AppendLine($"            RadiusY = {rectElement.RadiusY},");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is CircleElement circleElement)
            {
                sourceText.AppendLine(@"        new CircleDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(circleElement, sourceText);
                sourceText.AppendLine($"            Center = new Avalonia.Point({circleElement.CenterX}, {circleElement.CenterY}),");
                sourceText.AppendLine($"            Radius = {circleElement.Radius}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is EllipseElement ellipseElement)
            {
                sourceText.AppendLine(@"        new EllipseDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(ellipseElement, sourceText);
                sourceText.AppendLine($"            Center = new Avalonia.Point({ellipseElement.CenterX}, {ellipseElement.CenterY}),");
                sourceText.AppendLine($"            RadiusX = {ellipseElement.RadiusX},");
                sourceText.AppendLine($"            RadiusY = {ellipseElement.RadiusY}");
                sourceText.AppendLine(@"        },");
            }
            else if (graphicElement is LineElement lineElement)
            {
                sourceText.AppendLine(@"        new LineDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(lineElement, sourceText);
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
                GenerateCommonCode(polygonElement, sourceText);
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
                GenerateCommonCode(polylineElement, sourceText);
                sourceText.AppendLine($"            Points = [{string.Join(',', points)}]");
                sourceText.AppendLine(@"        },");
            }
            if (graphicElement is PathElement pathElement)
            {
                sourceText.AppendLine(@"        new PathDrawingInstruction()");
                sourceText.AppendLine(@"        {");
                GenerateCommonCode(pathElement, sourceText);
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

    private void GenerateCommonCode(SvgGraphicElement graphicElement, StringBuilder output)
    {
        output.AppendLine($"            Opacity = {graphicElement.Opacity},");
        if (!string.IsNullOrEmpty(graphicElement.Transform))
        {
            output.AppendLine($"            Transform = TransformParser.Parse(\"{graphicElement.Transform}\").Value,");
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
}