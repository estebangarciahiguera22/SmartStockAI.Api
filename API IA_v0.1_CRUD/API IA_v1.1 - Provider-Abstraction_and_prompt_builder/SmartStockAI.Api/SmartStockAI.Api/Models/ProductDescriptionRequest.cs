namespace SmartStockAI.Api.Models;

public class ProductDescriptionRequest
{
    public string Name { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Material { get; set; } = string.Empty;

    public string Stone { get; set; } = string.Empty;

    public string Collection { get; set; } = string.Empty;

    public string Style { get; set; } = string.Empty;

    public string TargetMarket { get; set; } = string.Empty;
}