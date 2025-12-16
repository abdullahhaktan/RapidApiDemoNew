using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiDemoNew.Models;

namespace RapidApiDemoNew.Controllers
{
    public class CurrencyController : Controller
    {
        public async Task<IActionResult> CurrencyConvert()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"),
                Headers =
                {
                    { "x-rapidapi-key", "b6a5624d34mshfcd3224e3121bffp1507c4jsnfd478a0285e4" },
                    { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<CurrencyViewModel>(body);
                ViewBag.v = value.result;
            }
            return View();
        }
    }
}
