using Entity_layer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;
using TravelReservation.Areas.Member.Models;

namespace TravelReservation.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);  //Şu an oturum açmış (login olmuş) olan kullanıcının kullanıcı adını User.Identity.Name ile alır.UserManager aracılığıyla bu kullanıcıyı veritabanında arar ve values değişkenine atar.
            UserEditViewModel userEditViewModel = new UserEditViewModel(); //Kullanıcıdan gelen bilgileri göstermek için bir ViewModel nesnesi oluşturur. ViewModel, View ile Controller arasında sadece gerekli alanların taşındığı bir sınıftır.
            //values içindeki bilgileri userEditViewModel içine koyar.Yani bu bilgiler formda gösterilecek olan veriler.
            userEditViewModel.name = values.Name;
            userEditViewModel.surname = values.Surname;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.mail = values.Email;
            return View(userEditViewModel);
        } 
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
         
            return View();
        }
    }
}
