using SmartStockAI.Api.Models;

namespace SmartStockAI.Api.AI;

public class PromptBuilder
{
    public string BuildProductDescriptionPrompt(ProductDescriptionRequest request)
    {
        return
            $"Generate a premium jewelry product description for the following product:\n\n" +
            $"Name: {request.Name}\n" +
            $"Category: {request.Category}\n" +
            $"Material: {request.Material}\n" +
            $"Stone: {request.Stone}\n" +
            $"Collection: {request.Collection}\n" +
            $"Style: {request.Style}\n" +
            $"Target Market: {request.TargetMarket}\n\n" +
            $"The description should sound elegant, emotional, premium, and suitable for an international jewelry brand.";
    }

    public string BuildMarketingCaptionPrompt(ProductDescriptionRequest request)
    {
        return
            $"Create a short social media caption for this jewelry product:\n\n" +
            $"Name: {request.Name}\n" +
            $"Category: {request.Category}\n" +
            $"Material: {request.Material}\n" +
            $"Stone: {request.Stone}\n" +
            $"Collection: {request.Collection}\n" +
            $"Style: {request.Style}\n" +
            $"Target Market: {request.TargetMarket}\n\n" +
            $"The caption should be elegant, concise, emotional, and suitable for Instagram.";
    }

    public string BuildProductStoryPrompt(ProductDescriptionRequest request)
    {
        return
            $"Write a short storytelling paragraph for this jewelry product:\n\n" +
            $"Name: {request.Name}\n" +
            $"Category: {request.Category}\n" +
            $"Material: {request.Material}\n" +
            $"Stone: {request.Stone}\n" +
            $"Collection: {request.Collection}\n" +
            $"Style: {request.Style}\n" +
            $"Target Market: {request.TargetMarket}\n\n" +
            $"The story should connect emotion, craftsmanship, elegance, and the symbolic value of the gemstone.";
    }
}