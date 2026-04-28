using SmartStockAI.Api.Models;

namespace SmartStockAI.Api.Services;

public class AiService : IAiService
{
    public ProductDescriptionResponse GenerateProductDescription(ProductDescriptionRequest request)
    {
        var description =
            $"Discover the {request.Name}, a {request.Style.ToLower()} {request.Category.ToLower()} " +
            $"crafted in {request.Material} with a beautiful {request.Stone}. " +
            $"Part of the {request.Collection} collection, designed for the {request.TargetMarket} market.";

        return new ProductDescriptionResponse
        {
            Description = description
        };
    }

    public StockSuggestionResponse GenerateStockSuggestion(StockSuggestionRequest request)
    {
        string suggestion;

        if (request.CurrentStock <= 0)
        {
            suggestion = $"{request.ProductName} is out of stock. Immediate restocking is recommended.";
        }
        else if (request.CurrentStock < request.MinimumStock)
        {
            suggestion = $"{request.ProductName} is below the minimum stock level. Consider restocking soon.";
        }
        else
        {
            suggestion = $"{request.ProductName} has enough stock for now.";
        }

        return new StockSuggestionResponse
        {
            Suggestion = suggestion
        };
    }
}