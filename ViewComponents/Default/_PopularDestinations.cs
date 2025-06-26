using Business_layer.Concrete;
using DataAccess_layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.Default
{
    public class _PopularDestinations: ViewComponent
    {
        DestinationManager destinationmanager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationmanager.TGetList();
            return View(values);
        }
    }
}
