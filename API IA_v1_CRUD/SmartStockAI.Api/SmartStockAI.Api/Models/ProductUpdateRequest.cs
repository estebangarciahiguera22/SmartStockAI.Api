namespace SmartStockAI.Api.Models;

public class ProductUpdateRequest
{
    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Material { get; set; } = string.Empty;

    public string Stone { get; set; } = string.Empty;

    public string Collection { get; set; } = string.Empty;

    public string Style { get; set; } = string.Empty;

    public int Stock { get; set; }

    public int MinimumStock { get; set; }

    public decimal Price { get; set; }

    public string Currency { get; set; } = "EUR";

    public string TargetMarket { get; set; } = string.Empty;
}