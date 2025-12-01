using System.Text.Json.Serialization;

namespace AtomUI.Icons.IconPark;

public class IconMetaInfo
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; } = string.Empty;

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("category")]
    public string Category { get; set; } = string.Empty;

    [JsonPropertyName("categoryCN")]
    public string CategoryCN { get; set; } = string.Empty;

    [JsonPropertyName("author")] 
    public string Author { get; set; } = string.Empty;

    [JsonPropertyName("tag")]
    public List<string> Tags { get; set; } = [];

    [JsonPropertyName("rtl")]
    public bool Rtl { get; set; }
}