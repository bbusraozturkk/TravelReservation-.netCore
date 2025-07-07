using AutoMapper;
using Business_layer.Abstract;
using DataAccess_layer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TravelReservation.Areas.Admin.Models;

namespace TravelReservation.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IAnnouncementService _announcementService;
        private readonly IMapper _mapper;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        public AnnouncementController(IMapper mapper)
        {
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var values = _mapper.Map<List<AnnouncementListDto>>(_announcementService.TGetList());

            return View(values);
        }
        [HttpGet]
        public IActionResult AddAnnouncement()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(AnnouncementAddDto model)
        {
            if (ModelState.IsValid)
            {
                _announcementService.TAdd(new Announcement()
                {
                    Content = model.Content,
                    Title = model.Title,
                    Date = Convert.ToDateTime(DateTime.Now.ToShortDateString())
                });

                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
