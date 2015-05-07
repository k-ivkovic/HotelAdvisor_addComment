using HotelAdvisor.Managers;
using HotelAdvisor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace HotelAdvisor.Controllers
{
    public class CommentController : Controller
    {
        // GET: Comment
        public ActionResult Index()
        {
            return View();
        }

        //create comment for specific hotel
        public ActionResult Create(int hotelId)
        {
            Comment model = new Comment() { HotelId = hotelId };

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(Comment model)
        {
            if (ModelState.IsValid)
            {
                model.DateAdded = DateTime.Now;
              //  model.UserId = User.Identity.GetUserId();

                CommentManager manager = new CommentManager();
                manager.Create(model);

                //TODO: redirect to the hotel details page
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}