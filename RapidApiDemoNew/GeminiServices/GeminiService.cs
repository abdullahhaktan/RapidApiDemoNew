
using Newtonsoft.Json;
using RapidApiDemoNew.GeminiDtos;

namespace RapidApiDemoNew.GeminiServices
{
    public class GeminiService : IGeminiService
    {
        private readonly HttpClient _client;
        private readonly string _apiKey;
        private const string Model = "gemini-2.5-flash";
        private const string BaseUrl = "https://generativelanguage.googleapis.com/v1beta/models/";

        public GeminiService(HttpClient client , IConfiguration configuration)
        {
            _client = client;
            _apiKey = configuration["Gemini:ApiKey"];
        }

        public async Task<string> GetGeminiFoodSuggestionAsync()
        {
            var prompt = "Şefin tavsiyesi yemek önerisi yap sadece öneriyi ve açıklamayı yaz, kendin extra bunun gibi şeyler yazma (tabiki yemek tavsiyesini iletiyorum)";
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

            var jsonContent = JsonConvert.SerializeObject(requestBody);
            var httpContent = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

            var url = $"{BaseUrl}{Model}:generateContent?key={_apiKey}";

            var response = await _client.PostAsync(url,httpContent);

            if(!response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }

            var responseString = await response.Content.ReadAsStringAsync();

            var geminiResponse = JsonConvert.DeserializeObject<GeminiResponseDto>(responseString);

            var resultText = geminiResponse.candidates.FirstOrDefault().content.parts.FirstOrDefault().text;

            return resultText ?? "Yanıt Alınamadı";

        }

        public async Task<string> GetGeminiPlaceSuggestionAsync()
        {
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
