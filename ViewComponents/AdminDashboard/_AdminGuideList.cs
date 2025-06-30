using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.AdminDashboard
{
    public class _AdminGuideList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
