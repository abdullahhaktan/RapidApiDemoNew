using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RapidApiDemoNew.Models;

namespace RapidApiDemoNew.Controllers
{
    public class HotelController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(HotelSearchRequest requestDto)
        {
            var client = new HttpClient();

            var destReq = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchDestination?query={Uri.EscapeDataString(requestDto.city)}"),
                Headers =
                {
                    { "x-rapidapi-key", "e738f473demsh7d5e50a5f1eec3dp1934b6jsn244af206ea2e" },
                    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                },
            };

            string destId;

            using (var response = await client.SendAsync(destReq))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<JObject>(body);

                destId = json["data"]?[0]?["dest_id"]?.ToString();

                if (string.IsNullOrEmpty(destId))
                {
                    ViewBag.error = $"'{requestDto.city}' için destinasyon bulunamadı.";
                    return View(requestDto);
                }
            }

            string childrenAges = string.IsNullOrEmpty(requestDto.children_age)
                ? ""
                : $"&children_age={Uri.EscapeDataString(requestDto.children_age)}";

            // 3️⃣ RAPIDAPI OTEL ARAMA
            var hotelReq = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(
                    $"https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?" +
                    $"dest_id={destId}" +
                    $"&search_type=CITY" +
                    $"&arrival_date={requestDto.arrival_date}" +
                    $"&departure_date={requestDto.departure_date}" +
                    $"&adults={requestDto.adults}" +
                    $"{childrenAges}" +
                    $"&room_qty={requestDto.room_qty}" +
                    $"&page_number=1" +
                    $"&units=metric" +
                    $"&temperature_unit=c" +
                    $"&languagecode=en-us" +
                    $"&currency_code=AED" +
                    $"&location=US"
                ),
                Headers =
                {
                    { "x-rapidapi-key", "e738f473demsh7d5e50a5f1eec3dp1934b6jsn244af206ea2e" },
                    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                },
            };

            using (var hotelResponse = await client.SendAsync(hotelReq))
            {
                hotelResponse.EnsureSuccessStatusCode();
                var hotelBody = await hotelResponse.Content.ReadAsStringAsync();
                var json = JsonConvert.DeserializeObject<JObject>(hotelBody);

                var hotels = json["data"]?["hotels"] as JArray;

                if (hotels != null && hotels.Count > 0)
                {
                    // 🔹 Session’a kaydet
                    HttpContext.Session.SetString("Hotels", hotelBody);
                    return RedirectToAction("Index", "HotelDetail");
                }
                else
                {
                    ViewBag.error = $"'{requestDto.city}' için otel bulunamadı. Parametrelerin RapidAPI ile tutarlı olduğundan emin olun.";
                    return View(requestDto);
                }
            }
        }
    }
}
