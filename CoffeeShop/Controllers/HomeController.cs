using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
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

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult UserRegistration()
        {
            return View();
        }
        public ActionResult AddUser(UserInfo newUser)
        {
            {

                if (ModelState.IsValid)
                {

                    ViewBag.ConfMessage = "Welcome " + newUser.FirstName;
                    ViewBag.Name = $"Name: {newUser.FirstName} {newUser.LastName}";
                    ViewBag.Email = $"Email: {newUser.Email}";

                    return View("Summary");
                }

                else
                {
                    ViewBag.Error = "Invalid. Please try again.";
                    return View("Error");
                }
            }
        }
    }
}