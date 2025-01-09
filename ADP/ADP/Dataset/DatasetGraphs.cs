using System.Text.Json.Serialization;

namespace ADP.Dataset;

public class DatasetGraphs
{
    [JsonPropertyName("lijnlijst")]
    public int[][] lijnlijst { get; set; }
    
    [JsonPropertyName("verbindingslijst")]
    public int[][] verbindingslijst { get; set; }
    
    [JsonPropertyName("verbindingsmatrix")]
    public int[][] verbindingsmatrix { get; set; }
    
    [JsonPropertyName("lijnlijst_gewogen")]
    public int[][] lijnlijst_gewogen { get; set; }
    
    [JsonPropertyName("verbindingslijst_gewogen")]
    public int[][][] verbindingslijst_gewogen { get; set; }
    
    [JsonPropertyName("verbindingsmatrix_gewogen")]
    public int[][] verbindingsmatrix_gewogen { get; set; }

}