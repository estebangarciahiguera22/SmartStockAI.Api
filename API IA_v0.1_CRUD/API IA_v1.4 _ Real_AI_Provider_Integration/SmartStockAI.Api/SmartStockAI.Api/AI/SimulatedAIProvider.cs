using Microsoft.Extensions.Options;
using SmartStockAI.Api.Configuration;

namespace SmartStockAI.Api.AI;

public class SimulatedAIProvider : IAIProvider
{
    private readonly AIProviderSettings _settings;

    public SimulatedAIProvider(IOptions<AIProviderSettings> options)
    {
        _settings = options.Value;
    }

    public string GenerateText(string prompt)
    {
        return
            $"[Provider: {_settings.ProviderName}] " +
            $"[Model: {_settings.Model}] " +
            $"[Simulated AI Response] {prompt}";
    }
}