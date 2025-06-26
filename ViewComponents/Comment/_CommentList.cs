using Business_layer.Concrete;
using DataAccess_layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.Comment
{
    public class _CommentList : ViewComponent
    {
        CommentManager commentManager = new CommentManager(new EfCommentDal());
        public IViewComponentResult Invoke(int id)
        {
            var values = commentManager.TGetDestinationById(id);
            return View(values);
        }
    }
}
