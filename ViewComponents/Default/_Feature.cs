using Business_layer.Concrete;
using DataAccess_layer.Concrete;
using DataAccess_layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            //var values = featureManager.TGetList(); 
            return View();
        }
    }
}
