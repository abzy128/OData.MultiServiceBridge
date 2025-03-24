namespace OData.MultiServiceBridge.Models;

public record ODataResponse<T>
{
    public long? Take { get; init; }
    public long? Skip { get; init; }
    public long? Count { get; init; }
    public IEnumerable<T> Value { get; init; } = [];
}