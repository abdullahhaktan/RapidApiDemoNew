using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RapidApiDemoNew.Models;
using System.Net.Http.Headers;

namespace RapidApiDemoNew.Controllers
{
    public class HotelDetailController : Controller
    {
        public IActionResult Index()
        {
            var hotelsJson = HttpContext.Session.GetString("Hotels");

            if (string.IsNullOrEmpty(hotelsJson))
            {
                return RedirectToAction("Index", "Hotel");
            }

            ViewBag.Hotels = hotelsJson;

            return View();
        }

        public IActionResult Details(int hotelId)
        {
            var hotelsJson = HttpContext.Session.GetString("Hotels");

            if (string.IsNullOrEmpty(hotelsJson))
            {
                return RedirectToAction("Index", "Hotel");
            }

            var data = JObject.Parse(hotelsJson);
            var hotels = data["data"]?["hotels"] as JArray;

            if (hotels == null)
            {
                return RedirectToAction("Index", "Hotel");
            }

            var hotel = hotels.FirstOrDefault(h => h["hotel_id"]?.ToString() == hotelId.ToString());

            if (hotel == null)
            {
                return RedirectToAction("Index", "Hotel");
            }

            ViewBag.Hotel = hotel;
            ViewBag.hotelId = Convert.ToInt32(hotelId);

            return View();
        }

        public async Task<IActionResult> PhotosSlider(int hotelId)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"https://booking-com15.p.rapidapi.com/api/v1/hotels/getHotelPhotos?hotel_id={hotelId}"),
                Headers =
                {
                    { "x-rapidapi-key", "e738f473demsh7d5e50a5f1eec3dp1934b6jsn244af206ea2e" },
                    { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                var values = JsonConvert.DeserializeObject<HotelPhotosViewModel>(body);

                ViewBag.PhotoUrl1 = values.data[0].url;
                ViewBag.PhotoUrl2 = values.data[1].url;
                ViewBag.PhotoUrl3 = values.data[2].url;
                ViewBag.PhotoUrl4 = values.data[3].url;
                ViewBag.PhotoUrl5 = values.data[4].url;
                ViewBag.PhotoUrl6 = values.data[5].url;
                ViewBag.PhotoUrl7 = values.data[6].url;
                ViewBag.PhotoUrl8 = values.data[7].url;
            }

            return View();
        }
    }
}
