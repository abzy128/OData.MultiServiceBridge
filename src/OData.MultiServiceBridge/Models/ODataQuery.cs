using System.Text.Json.Serialization;

namespace OData.MultiServiceBridge.Models;

public record ODataQuery
{
    [JsonPropertyName("$select")]
    string? Select { get; init; }
    
    [JsonPropertyName("$filter")]
    string? Filter { get; init; }
    
    [JsonPropertyName("$expand")]
    string? Expand { get; init; }
    
    [JsonPropertyName("$orderby")]
    string? OrderBy { get; init; }
    
    [JsonPropertyName("$top")]
    long? Top { get; init; }

    [JsonPropertyName("$skip")]
    long? Skip { get; init; }
    
    [JsonPropertyName("$count")]
    bool? Count { get; init; }
}