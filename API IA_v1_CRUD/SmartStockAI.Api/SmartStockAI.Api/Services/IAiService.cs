using SmartStockAI.Api.Models;

namespace SmartStockAI.Api.Services;

public interface IAiService
{
    ProductDescriptionResponse GenerateProductDescription(ProductDescriptionRequest request);

    StockSuggestionResponse GenerateStockSuggestion(StockSuggestionRequest request);
}