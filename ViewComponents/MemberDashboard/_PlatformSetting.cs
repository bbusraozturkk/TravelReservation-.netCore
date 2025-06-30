using Business_layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TravelReservation.ViewComponents.MemberDashboard
{
    public class _PlatformSetting:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
