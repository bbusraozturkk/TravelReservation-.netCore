﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TravelReservation.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        } 
        public PartialViewResult PartialAppBrandDemo()
        {
            return PartialView();
        } 
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        } 
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }   
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}
