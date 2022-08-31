using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
// make sure to include these using directives
using Ch25Cart.Models;

namespace Ch25Cart.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            ViewBag.HeaderText = "Welcome to the Halloween Store";
            ViewData["FooterText"] = "Where every day is Halloween!";
            return View();
        }
        [HttpGet]
        public ViewResult Contact()
        {
            ContactViewModel model = new ContactViewModel();
            return View(model);
        }
    }
}