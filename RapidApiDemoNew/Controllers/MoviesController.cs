using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiDemoNew.Models;
using System.Net.Http.Headers;

namespace RapidApiDemoNew.Controllers
{
    public class MoviesController : Controller
    {
        public async Task<IActionResult> ImdbTop100List()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                {
                    { "x-rapidapi-key", "ApiKey" },
                    { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ImdbMovieViewModel>>(body);
                return View(values.ToList());
            }
        }
    }
}
