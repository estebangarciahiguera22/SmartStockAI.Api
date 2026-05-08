using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Options;
using SmartStockAI.Api.Configuration;

namespace SmartStockAI.Api.AI;

public class OpenAIProvider : IAIProvider
{
    private readonly HttpClient _httpClient;
    private readonly AIProviderSettings _settings;

    public OpenAIProvider(HttpClient httpClient, IOptions<AIProviderSettings> options)
    {
        _httpClient = httpClient;
        _settings = options.Value;
    }

    public string GenerateText(string prompt)
    {
        if (string.IsNullOrWhiteSpace(_settings.ApiKey))
        {
            return "AI provider API key is missing. Please configure it using user secrets or environment variables.";
        }

        var requestBody = new
        {
            model = _settings.Model,
            input = prompt
        };

        var json = JsonSerializer.Serialize(requestBody);

        using var request = new HttpRequestMessage(HttpMethod.Post, _settings.BaseUrl);
        request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _settings.ApiKey);
        request.Content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = _httpClient.Send(request);
        var responseContent = response.Content.ReadAsStringAsync().Result;

        if (!response.IsSuccessStatusCode)
        {
            return $"AI provider error: {response.StatusCode}. Details: {responseContent}";
        }

        using var document = JsonDocument.Parse(responseContent);

        if (document.RootElement.TryGetProperty("output_text", out var outputText))
        {
            return outputText.GetString() ?? string.Empty;
        }

        return responseContent;
    }
}