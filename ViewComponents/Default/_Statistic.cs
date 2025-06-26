using Business_layer.Concrete;
using DataAccess_layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TravelReservation.ViewComponents.Default
{
    public class _Statistic:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
