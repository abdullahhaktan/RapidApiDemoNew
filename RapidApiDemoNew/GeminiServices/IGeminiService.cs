namespace RapidApiDemoNew.GeminiServices
{
    public interface IGeminiService
    {
        Task<string> GetGeminiFoodSuggestionAsync();
        Task<string> GetGeminiPlaceSuggestionAsync();
    }
}
