﻿using Business_layer.Concrete;
using DataAccess_layer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TravelReservation.ViewComponents.Comment
{
    public class _AddComment : ViewComponent
    {
        //CommentManager commentManager = new CommentManager(new EfCommentDal());

        //[HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        } 
        //[HttpPost]
        //public IViewComponentResult Invoke(Entity_layer.Concrete.Comment p)
        //{
        //    p.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
        //    p.CommentState = true;
        //    commentManager.TAdd(p);
        //    return View();
        //}
    }
}
