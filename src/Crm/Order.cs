namespace Crm;

public sealed class Order
{
    int id;
    string? name;
    string? color;
    short price;
    string? description;
    public required int Id 
    {
        get => id;
        init => id = value >= 1 ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public required string Name
    {
        get => name ?? string.Empty;
        init => name = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public string Color 
    { 
        get => color ?? string.Empty;
        init => color = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
    public short Price { get; init; }

    public string Description 
    {
        get => description ?? string.Empty;
        set => description = value is { Length: > 0 } ? value : throw new ArgumentOutOfRangeException(nameof(value));
    }
}