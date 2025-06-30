using Business_layer.Abstract;
using Business_layer.Concrete;
using DataAccess_layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            var values = _commentService.TGetListCommentWithDestination();
            return View();
        }

        public IActionResult DeleteComment(int id)
        {
            var values = _commentService.TGetByID(id); _commentService.TDelete(values);
            return RedirectToAction("Index");
        }

    }
}
