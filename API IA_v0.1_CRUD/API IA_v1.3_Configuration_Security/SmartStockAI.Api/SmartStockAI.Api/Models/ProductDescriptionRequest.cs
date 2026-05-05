using System.ComponentModel.DataAnnotations;

namespace SmartStockAI.Api.Models;

public class ProductDescriptionRequest
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

    [Required(ErrorMessage = "Target market is required.")]
    [MinLength(2, ErrorMessage = "Target market must have at least 2 characters.")]
    public string TargetMarket { get; set; } = string.Empty;
}