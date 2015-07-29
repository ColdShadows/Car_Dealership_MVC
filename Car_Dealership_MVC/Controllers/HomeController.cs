using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Dealership_MVC.Models;
using System.Data.Entity;
using System.Data;
using System.Net;
using Car_Dealership_MVC.DAL;
using Car_Dealership_MVC.ViewModel;

namespace Car_Dealership_MVC.Controllers
{
    public class HomeController : Controller
    {
        private DealershipContext db = new DealershipContext();
        public ActionResult Index()
        {
            List<Customer> customerList = new List<Customer>();
            ViewBag.isLoggedIn = false;
            LoginViewModel login = new LoginViewModel();
            return View(login);
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel login)
        {
            ViewBag.Message = "This log in didn't break anything.";

            ViewBag.isLoggedIn = false;

            var q = from c in db.users
                    where login.Username == c.UserName
                    select c;
            q = q.Where(u => u.UserName.Equals(login.Username));

            int count = q.Count(u => u.UserName == u.UserName);
            if (count == 1 && q.First().Password == login.Password)
            {
                Customer customer = (from c in q
                                     select c).First();
                ViewBag.isLoggedIn = true;
                ViewBag.Username = customer.UserName;
                ViewBag.Name = customer.Name;
                ViewBag.carID = customer.carID;
            }
            return View();
        }

        public ActionResult About()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            var vehicleQry = from v in db.inventory
                             group v by new { makeG = v.make, modelG = v.model, yearG = v.year } into vGroup
                             orderby vGroup.Key.makeG
                             select new VehicleGroup()
                             {
                                 Make = vGroup.Key.makeG,
                                 Model = vGroup.Key.modelG,
                                 Year = vGroup.Key.yearG,
                                 VehicleCount = vGroup.Count()
                             };
                                                 
                
                            

            return View(vehicleQry);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}