﻿using Business_layer.Abstract;
using DocumentFormat.OpenXml.Office2010.Excel;
using Entity_layer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using TravelReservation.Models;

namespace TravelReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        } 
        
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            destination.Status = true;
            _destinationService.TAdd(destination);
          var values = JsonConvert.SerializeObject(destination);
            return Json(values);
        }

        public IActionResult GetById(int DestinationID)
        {
            var values = _destinationService.TGetByID(DestinationID);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
        public IActionResult DeleteCity(int id)
        {
            var values = _destinationService.TGetByID(id);
            _destinationService.TDelete(values);
            return NoContent();
        }
        public IActionResult UpdateCity(Destination destination)
        {
            var values = _destinationService.TGetByID(destination.DestinationID);
            _destinationService.TUpdate(values);
            var v= JsonConvert.SerializeObject(destination);
            return Json(v);
        }

        public static List<CityClass> cities = new List<CityClass>
        {
            new CityClass
            {
                CityID = 1,
                CityName = "Üsküp",
                CityCountry = "Makedonya"
            }
        };

      
    }
}
