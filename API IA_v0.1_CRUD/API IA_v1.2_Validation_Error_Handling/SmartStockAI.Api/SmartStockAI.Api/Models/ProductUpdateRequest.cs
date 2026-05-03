using System.ComponentModel.DataAnnotations;

namespace SmartStockAI.Api.Models;

public class ProductUpdateRequest
{
    [Required(ErrorMessage = "Product name is required.")]
    [MinLength(2, ErrorMessage = "Product name must have at least 2 characters.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "Category is required.")]
    [MinLength(2, ErrorMessage = "Category must have at least 2 characters.")]
    public string Category { get; set; } = string.Empty;

    [Required(ErrorMessage = "Material is required.")]
    [MinLength(2, ErrorMessage = "Material must have at least 2 characters.")]
    public string Material { get; set; } = string.Empty;

    [Required(ErrorMessage = "Stone is required.")]
    [MinLength(2, ErrorMessage = "Stone must have at least 2 characters.")]
    public string Stone { get; set; } = string.Empty;

    [Required(ErrorMessage = "Collection is required.")]
    [MinLength(2, ErrorMessage = "Collection must have at least 2 characters.")]
    public string Collection { get; set; } = string.Empty;

    [Required(ErrorMessage = "Style is required.")]
    [MinLength(2, ErrorMessage = "Style must have at least 2 characters.")]
    public string Style { get; set; } = string.Empty;

    [Range(0, int.MaxValue, ErrorMessage = "Stock must be greater than or equal to 0.")]
    public int Stock { get; set; }

    [Range(0, int.MaxValue, ErrorMessage = "Minimum stock must be greater than or equal to 0.")]
    public int MinimumStock { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
    public decimal Price { get; set; }

    [Required(ErrorMessage = "Currency is required.")]
    [StringLength(3, MinimumLength = 3, ErrorMessage = "Currency must be a 3-letter code, for example EUR or USD.")]
    public string Currency { get; set; } = "EUR";

    [Required(ErrorMessage = "Target market is required.")]
    [MinLength(2, ErrorMessage = "Target market must have at least 2 characters.")]
    public string TargetMarket { get; set; } = string.Empty;
}