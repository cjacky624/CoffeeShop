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
                    ViewBag.Birthday = $"Birthday: {newUser.Birthday}";

                    return View("Summary");
                }

                else
                {
                    ViewBag.Error = "Invalid. Please try again.";
                    return View("UserRegistration");
                }
            }
        }
        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult FindItem(string name)
        {
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();
            //find item
            Item ItemToEdit = ORM.Items.Find(name);

            if (ItemToEdit == null)
            {
                return RedirectToAction("Index");
            }

            ViewBag.ItemToEdit = ItemToEdit;
            return View();

        }
        public ActionResult DeleteItem(string name)
        {
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();

            Item ItemToDelete = ORM.Items.Find(name); 

            ORM.Items.Remove(ItemToDelete);

            ORM.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}