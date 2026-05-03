using Microsoft.AspNetCore.Mvc;
using SmartStockAI.Api.Models;
using SmartStockAI.Api.Services;

namespace SmartStockAI.Api.Controllers;

[ApiController]
[Route("api/ai")]
public class AiController : ControllerBase
{
    private readonly IAiService _aiService;

    public AiController(IAiService aiService)
    {
        _aiService = aiService;
    }

    [HttpPost("product-description")]
    public IActionResult GenerateProductDescription(ProductDescriptionRequest request)
    {
        var response = _aiService.GenerateProductDescription(request);
        return Ok(response);
    }

    [HttpPost("marketing-caption")]
    public IActionResult GenerateMarketingCaption(ProductDescriptionRequest request)
    {
        var response = _aiService.GenerateMarketingCaption(request);
        return Ok(response);
    }

    [HttpPost("product-story")]
    public IActionResult GenerateProductStory(ProductDescriptionRequest request)
    {
        var response = _aiService.GenerateProductStory(request);
        return Ok(response);
    }

    [HttpPost("stock-suggestion")]
    public IActionResult GenerateStockSuggestion(StockSuggestionRequest request)
    {
        var response = _aiService.GenerateStockSuggestion(request);
        return Ok(response);
    }
}