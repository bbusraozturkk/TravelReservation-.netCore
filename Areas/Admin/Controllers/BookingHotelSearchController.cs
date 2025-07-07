using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace TravelReservation.Areas.Admin.Controllers
{
    public class BookingHotelSearchController : Controller
    {
        public async Task<IActionResult> IndexAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://booking-com15.p.rapidapi.com/api/v1/hotels/searchHotels?dest_id=-2092174&search_type=CITY&adults=1&children_age=0%2C17&room_qty=1&page_number=1&units=metric&temperature_unit=c&languagecode=en-us&currency_code=AED&location=US"),
                Headers =
    {
        { "x-rapidapi-key", "a81fe46103msh7f2f114d9d7af45p184381jsne8a544c1bb46" },
        { "x-rapidapi-host", "booking-com15.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                Console.WriteLine(body);
            }
            return View();
        }
    }
}
