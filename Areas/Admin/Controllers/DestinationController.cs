﻿using Business_layer.Abstract;
using Business_layer.Concrete;
using DataAccess_layer.EntityFramework;
using Entity_layer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var values = _destinationService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddDestination()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDestination(int id)
        {
            var values = _destinationService.TGetByID(id);
            return View("values");
        }
        [HttpPost]
        public IActionResult UpdateDestination(Destination destination)
        {

            _destinationService.TUpdate(destination);
            return RedirectToAction("Index");
        }
    }
}
