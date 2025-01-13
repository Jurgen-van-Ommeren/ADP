using System.Text.Json.Serialization;
using ADP.TestObjects;

namespace ADP.Dataset;

public class DatasetHashing
{
    [JsonPropertyName("hashtabelsleutelswaardes")]
    public Dictionary<string, int[]> Hashtabelsleutelswaardes { get; set; }
}