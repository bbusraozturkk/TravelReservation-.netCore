using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using System;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using TravelReservation.Areas.Admin.Models;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TravelReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ApiMovieController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<ApiMovieViewModel> apiMovies = new List<ApiMovieViewModel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "x-rapidapi-key", "a81fe46103msh7f2f114d9d7af45p184381jsne8a544c1bb46" },
        { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                apiMovies = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                return View();
            }

           
        }
    }
}
