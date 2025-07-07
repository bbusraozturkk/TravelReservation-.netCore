using Microsoft.AspNetCore.Mvc;
using TravelReservation.CQRS.Commands.DestinationCommands;
using TravelReservation.CQRS.Handlers.DestinationHandlers;
using TravelReservation.CQRS.Queries.DestinationQueries;

namespace TravelReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationCQRSController : Controller
    {
        private readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
        private readonly GetDestinationByIDQueryHandler _getDestinationByIDQueryHandler;
        private readonly CreateDestinationCommandHandler _createDestinationCommandHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler getAllDestinationQueryHandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
        }

        public DestinationCQRSController(GetDestinationByIDQueryHandler getDestinationByIDQueryHandler)
        {
            _getDestinationByIDQueryHandler = getDestinationByIDQueryHandler;
        }

        public IActionResult Index()
        {
            var values = _getAllDestinationQueryHandler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult GetDestination(int id)
        {
            var values = _getDestinationByIDQueryHandler.Handle(new GetDestinationByIDQuery(id));
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
