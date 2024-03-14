using System.Text.Json.Serialization;

public class Character
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("height")]
    public string Height { get; set; }
}
