using SmartStockAI.Api.AI;
using SmartStockAI.Api.Models;

namespace SmartStockAI.Api.Services;

public class AiService : IAiService
{
    private readonly IAIProvider _aiProvider;
    private readonly PromptBuilder _promptBuilder;

    public AiService(IAIProvider aiProvider, PromptBuilder promptBuilder)
    {
        _aiProvider = aiProvider;
        _promptBuilder = promptBuilder;
    }

    public ProductDescriptionResponse GenerateProductDescription(ProductDescriptionRequest request)
    {
        var prompt = _promptBuilder.BuildProductDescriptionPrompt(request);
        var generatedText = _aiProvider.GenerateText(prompt);

        return new ProductDescriptionResponse
        {
            Description = generatedText
        };
    }

    public ProductDescriptionResponse GenerateMarketingCaption(ProductDescriptionRequest request)
    {
        var prompt = _promptBuilder.BuildMarketingCaptionPrompt(request);
        var generatedText = _aiProvider.GenerateText(prompt);

        return new ProductDescriptionResponse
        {
            Description = generatedText
        };
    }

    public ProductDescriptionResponse GenerateProductStory(ProductDescriptionRequest request)
    {
        var prompt = _promptBuilder.BuildProductStoryPrompt(request);
        var generatedText = _aiProvider.GenerateText(prompt);

        return new ProductDescriptionResponse
        {
            Description = generatedText
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