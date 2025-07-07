using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TravelReservation.CQRS.Queries.GuideQueries;

namespace TravelReservation.Areas.Admin.Controllers
{
    public class DestinationMediatRController : Controller
    {
        private readonly IMediator _mediator;

        public DestinationMediatRController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _mediator.Send(new GetAllGuideQuery());
            return View(values);
        }
    }
}
