namespace SmartStockAI.Api.Models;

public class StockSuggestionRequest
{
    public string ProductName { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public int CurrentStock { get; set; }

    public int MinimumStock { get; set; }
}