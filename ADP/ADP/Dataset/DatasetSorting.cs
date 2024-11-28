﻿using System.Text.Json.Serialization;

namespace ADP.Dataset;

public class DatasetSorting
{
    [JsonPropertyName("lijst_aflopend_2")]
    public int[] LijstAflopend2 { get; set; }

    [JsonPropertyName("lijst_oplopend_2")]
    public int[] LijstOplopend2 { get; set; }

    [JsonPropertyName("lijst_float_8001")]
    public float[] LijstFloat8001 { get; set; }

    [JsonPropertyName("lijst_gesorteerd_aflopend_3")]
    public int[] LijstGesorteerdAflopend3 { get; set; }

    [JsonPropertyName("lijst_gesorteerd_oplopend_3")]
    public int[] LijstGesorteerdOplopend3 { get; set; }

    [JsonPropertyName("lijst_herhaald_1000")]
    public int[] LijstHerhaald1000 { get; set; }

    [JsonPropertyName("lijst_leeg_0")]
    public object[] LijstLeeg0 { get; set; }

    [JsonPropertyName("lijst_null_1")]
    public object[] LijstNull1 { get; set; }

    [JsonPropertyName("lijst_null_3")]
    public int?[] LijstNull3 { get; set; }

    [JsonPropertyName("lijst_onsorteerbaar_3")]
    public object[] LijstOnsorteerbaar3 { get; set; }

    [JsonPropertyName("lijst_oplopend_10000")]
    public int[] LijstOplopend10000 { get; set; }

    [JsonPropertyName("lijst_willekeurig_10000")]
    public int[] LijstWillekeurig10000 { get; set; }

    [JsonPropertyName("lijst_willekeurig_3")]
    public int[] LijstWillekeurig3 { get; set; }
}