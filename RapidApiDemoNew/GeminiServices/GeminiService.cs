using Newtonsoft.Json;
using RapidApiDemoNew.GeminiDtos;

namespace RapidApiDemoNew.GeminiServices
{
    public class GeminiService : IGeminiService
    {
        // HttpClient and configuration for Gemini API
        private readonly HttpClient _client;
        private readonly string _apiKey;
        private const string Model = "gemini-2.5-flash";
        private const string BaseUrl = "https://generativelanguage.googleapis.com/v1beta/models/";

        public GeminiService(HttpClient client, IConfiguration configuration)
        {
            _client = client;
            _apiKey = configuration["Gemini:ApiKey"]; // API key from app settings
        }

        // Get food recommendations from Gemini AI
        public async Task<string> GetGeminiFoodSuggestionAsync()
        {
            // Prompt for chef-style food recommendation
            var prompt = "Şefin tavsiyesi yemek önerisi yap sadece öneriyi ve açıklamayı yaz, kendin extra bunun gibi şeyler yazma (tabiki yemek tavsiyesini iletiyorum)";

            var requestBody = new GeminiRequestDto
            {
                contents = new List<Content>
                {
                    new Content
                    {
                        role = "user", // User role for the prompt
                        parts = new List<Part>
                        {
                            new Part
                            {
                                text = prompt
                            }
                        }
                    }
                },
                generationConfig = new GenerationConfig
                {
                    temperature = 1f, // Maximum creativity
                    maxOutputTokens = 2000 // Response length limit
                }
            };

            // Serialize request and prepare HTTP content
            var jsonContent = JsonConvert.SerializeObject(requestBody);
            var httpContent = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            // Build API URL with model and API key
            var url = $"{BaseUrl}{Model}:generateContent?key={_apiKey}";

            // Send request to Gemini API
            var response = await _client.PostAsync(url, httpContent);

            // Handle unsuccessful responses
            if (!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }

            // Process successful response
            var responseString = await response.Content.ReadAsStringAsync();
            var geminiResponse = JsonConvert.DeserializeObject<GeminiResponseDto>(responseString);

            // Extract text from nested response structure
            var resultText = geminiResponse.candidates.FirstOrDefault().content.parts.FirstOrDefault().text;

            return resultText ?? "Yanıt Alınamadı"; // Fallback message
        }

        // Get place recommendations for Antalya from Gemini AI
        public async Task<string> GetGeminiPlaceSuggestionAsync()
        {
            // Prompt for Antalya travel recommendations
            var prompt = "Antalyada Gezilecek 3 yer önerisi yap ayrı ayrı paragaflarda ver sadece açıklamaları ver kısa açıklamalar olsun ve sadece önerileri yaz 'elbette işte öneriler' gibi açıklama yapma extra ";

            var requestBody = new GeminiRequestDto
            {
                contents = new List<Content>
                {
                    new Content
                    {
                        role = "user",
                        parts = new List<Part>
                        {
                            new Part
                            {
                                text = prompt
                            }
                        }
                    }
                },
                generationConfig = new GenerationConfig
                {
                    temperature = 1f,
                    maxOutputTokens = 2000
                }
            };

            // Same pattern as above method (consider refactoring common code)
            var jsonContent = JsonConvert.SerializeObject(requestBody);
            var httpContent = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            var url = $"{BaseUrl}{Model}:generateContent?key={_apiKey}";

            var response = await _client.PostAsync(url, httpContent);

            if (!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }

            var responseString = await response.Content.ReadAsStringAsync();
            var geminiResponse = JsonConvert.DeserializeObject<GeminiResponseDto>(responseString);

            var resultText = geminiResponse.candidates.FirstOrDefault().content.parts.FirstOrDefault().text;

            return resultText ?? "Yanıt Alınamadı";
        }
    }
}