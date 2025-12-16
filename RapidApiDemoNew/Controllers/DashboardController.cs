using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiDemoNew.GeminiServices;
using RapidApiDemoNew.Models;

namespace RapidApiDemoNew.Controllers
{
    public class DashboardController(IGeminiService _geminiService) : Controller
    {
        private const string ApiKey = "e738f473demsh7d5e50a5f1eec3dp1934b6jsn244af206ea2e";
        private const string Host = "currency-conversion-and-exchange-rates.p.rapidapi.com";

        public async Task<IActionResult> Index()
        {
            var yesterday = DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd");

            double usdToday, usdYesterday, eurToday, eurYesterday;

            // ========= USD BUGÜN =========
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(
                        "https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1"
                    ),
                    Headers =
                    {
                        { "x-rapidapi-key", ApiKey },
                        { "x-rapidapi-host", Host },
                    },
                };

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ConvertResponse>(body);
                usdToday = data.info.rate;
            }

            // ========= USD DÜN =========
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(
                        $"https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=TRY&amount=1&date={yesterday}"
                    ),
                    Headers =
                    {
                        { "x-rapidapi-key", ApiKey },
                        { "x-rapidapi-host", Host },
                    },
                };

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ConvertResponse>(body);
                usdYesterday = data.info.rate;
            }

            // ========= EUR BUGÜN =========
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(
                        "https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1"
                    ),
                    Headers =
                    {
                        { "x-rapidapi-key", ApiKey },
                        { "x-rapidapi-host", Host },
                    },
                };

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ConvertResponse>(body);
                eurToday = data.info.rate;
            }

            // ========= EUR DÜN =========
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(
                        $"https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=TRY&amount=1&date={yesterday}"
                    ),
                    Headers =
                    {
                        { "x-rapidapi-key", ApiKey },
                        { "x-rapidapi-host", Host },
                    },
                };

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ConvertResponse>(body);
                eurYesterday = data.info.rate;
            }


            double btcToday, btcYesterday;

            //BTC BUGÜN
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=BTC&to=USD&amount=1"
                    ),
                    Headers =
                    {
                                   { "x-rapidapi-key", ApiKey },
            { "x-rapidapi-host", Host },
                    }
                };
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ConvertResponse>(body);
                btcToday = data.info.rate;
            }

            // ========= BTC DÜN =========
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri(
                        $"https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=BTC&to=USD&amount=1&date={yesterday}"
                    ),
                    Headers =
                    {
                        { "x-rapidapi-key", ApiKey },
                        { "x-rapidapi-host", Host },
                    },
                };

                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                var body = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<ConvertResponse>(body);
                btcYesterday = data.info.rate;
            }

            double btcChange = ((btcToday - btcYesterday) / btcYesterday) * 100;

            //double ethYesterday, ethToday;

            //// ========= ETH BUGÜN =========
            //using (var client = new HttpClient())
            //{
            //    var request = new HttpRequestMessage
            //    {
            //        Method = HttpMethod.Get,
            //        RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=Etherium&to=USD&amount=1"
            //        ),
            //        Headers =
            //        {
            //            { "x-rapidapi-key", ApiKey },
            //            { "x-rapidapi-host", Host },
            //        }
            //    };
            //    var response = await client.SendAsync(request);
            //    response.EnsureSuccessStatusCode();

            //    var body = await response.Content.ReadAsStringAsync();
            //    var data = JsonConvert.DeserializeObject<ConvertResponse>(body);
            //    ethToday = data.info.rate;
            //}


            //// ========= ETH DÜN =========
            //using (var client = new HttpClient())
            //{
            //    var request = new HttpRequestMessage
            //    {
            //        Method = HttpMethod.Get,
            //        RequestUri = new Uri(
            //            $"https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=Etherium&to=USD&amount=1&date={yesterday}"
            //        ),
            //        Headers =
            //        {
            //            { "x-rapidapi-key", ApiKey },
            //            { "x-rapidapi-host", Host },
            //        },
            //    };

            //    var response = await client.SendAsync(request);
            //    response.EnsureSuccessStatusCode();

            //    var body = await response.Content.ReadAsStringAsync();
            //    var data = JsonConvert.DeserializeObject<ConvertResponse>(body);
            //    ethYesterday = data.info.rate;
            //}

            //double ethChange = ((ethToday - ethYesterday) / ethYesterday) * 100;


            //Fuel
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://gas-price.p.rapidapi.com/europeanCountries"),
                    Headers =
                    {
                        { "x-rapidapi-key", "e738f473demsh7d5e50a5f1eec3dp1934b6jsn244af206ea2e" },
                        { "x-rapidapi-host", "gas-price.p.rapidapi.com" },
                    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var apiResponse = JsonConvert.DeserializeObject<FuelViewModel>(body);
                    var results = apiResponse.result.FirstOrDefault(f => f.country == "Turkey");

                    if (results != null)
                    {
                        ViewBag.diesel = double.Parse(results.diesel) * eurToday;
                        ViewBag.lpg = double.Parse(results.lpg) * eurToday;
                        ViewBag.gasoline = double.Parse(results.gasoline) * eurToday;
                    }
                }
            }

            // Weather
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city?city=Antalya&lang=TR"),
                    Headers =
                    {
                        { "x-rapidapi-key", "e738f473demsh7d5e50a5f1eec3dp1934b6jsn244af206ea2e" },
                        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
                    },
                };

                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    // JSON'u deserialize et
                    var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);

                    // Fahrenheit değeri al
                    double F = values.main.temp;

                    // Fahrenheit -> Celsius
                    double C = (F - 32) * 5.0 / 9.0;  // 5/9.0 ile double bölme yaptık

                    // ViewBag ile gönder
                    ViewBag.C = Math.Round(C, 1);  // 1 ondalık hassasiyet
                    ViewBag.WeatherDescription = values.weather[0].description;
                    ViewBag.WindSpeed = values.wind.speed;
                    ViewBag.Humidity = values.main.humidity;
                }
            }


            var model = new DashboardViewModel
            {
                UsdTry = usdToday,
                EurTry = eurToday,
                BtcUsd = btcToday,
                //EthUsd = ethToday,
                UsdTryChange = ((usdToday - usdYesterday) / usdYesterday) * 100,
                EurTryChange = ((eurToday - eurYesterday) / eurYesterday) * 100,
                BtcChange = btcChange,
                //EthChange = ethChange,
            };

            var foodSuggestion = await _geminiService.GetGeminiFoodSuggestionAsync();

            ViewBag.foodSuggestion = foodSuggestion;

            var placeSuggestion = await _geminiService.GetGeminiPlaceSuggestionAsync();

            ViewBag.placeSuggestion = placeSuggestion;

            return View(model);
        }
    }
}
