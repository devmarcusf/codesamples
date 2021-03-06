﻿using System.Security.Claims;
using System.Web.Mvc;
using ClaimTypes = System.IdentityModel.Claims.ClaimTypes;

namespace ManualFullFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize]
        public ActionResult Contact()
        {
            string userFirstName = ClaimsPrincipal.Current.FindFirst(ClaimTypes.GivenName).Value;
            ViewBag.Message = $"Welcome {userFirstName}!";

            return View();
        }
    }
}