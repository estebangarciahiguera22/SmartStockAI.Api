namespace SmartStockAI.Api.AI;

public class SimulatedAIProvider : IAIProvider
{
    public string GenerateText(string prompt)
    {
        return $"[Simulated AI Response] {prompt}";
    }
}