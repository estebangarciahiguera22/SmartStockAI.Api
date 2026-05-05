namespace SmartStockAI.Api.Configuration;

public class AIProviderSettings
{
    public string ProviderName { get; set; } = "SimulatedAI";

    public string ApiKey { get; set; } = string.Empty;

    public string BaseUrl { get; set; } = string.Empty;

    public string Model { get; set; } = string.Empty;
}