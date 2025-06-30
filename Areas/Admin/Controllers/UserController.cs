using Business_layer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IReservationService _reservationService;
        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
           _appUserService = appUserService;
           _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.TGetList();
            return View(values);
        }

        public IActionResult CommentUser(int id)
        {
            _appUserService.TGetList();
            return View();
        }

        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }


    }
}
