using SmartStockAI.Api.Models;

namespace SmartStockAI.Api.Services;

public interface IAiService
{
    ProductDescriptionResponse GenerateProductDescription(ProductDescriptionRequest request);

    ProductDescriptionResponse GenerateMarketingCaption(ProductDescriptionRequest request);

    ProductDescriptionResponse GenerateProductStory(ProductDescriptionRequest request);

    StockSuggestionResponse GenerateStockSuggestion(StockSuggestionRequest request);
}