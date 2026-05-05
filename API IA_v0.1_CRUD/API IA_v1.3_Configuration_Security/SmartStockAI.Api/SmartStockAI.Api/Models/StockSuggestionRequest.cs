using System.ComponentModel.DataAnnotations;

namespace SmartStockAI.Api.Models;

public class StockSuggestionRequest
{
    [Required(ErrorMessage = "Product name is required.")]
    [MinLength(2, ErrorMessage = "Product name must have at least 2 characters.")]
    public string ProductName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Category is required.")]
    [MinLength(2, ErrorMessage = "Category must have at least 2 characters.")]
    public string Category { get; set; } = string.Empty;

    [Range(0, int.MaxValue, ErrorMessage = "Current stock must be greater than or equal to 0.")]
    public int CurrentStock { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Minimum stock must be greater than or equal to 0.")]
    public int MinimumStock { get; set; }
}