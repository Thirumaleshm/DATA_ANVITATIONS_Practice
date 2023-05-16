using DATA_ANVITATIONS_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DATA_ANVITATIONS_Practice.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Msg = "Data Submitted Successfully";
            }
            else
            {
                ViewBag.Msg = "One (or) more validations failed";
            }
            return View("Index");
        }
    }
}