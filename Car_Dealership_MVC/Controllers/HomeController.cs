using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Car_Dealership_MVC.Models;
using System.Data.Entity;
using System.Data;
using System.Net;

namespace Car_Dealership_MVC.Controllers
{
    public class HomeController : Controller
    {
        private VehicleDBContext db = new VehicleDBContext(); 
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            List<Vehicle> vehicleList = new List<Vehicle>();

           /* var makeQry = from v in db.inventory
                             orderby v.make.Distinct()
                             select new 
                             {
                                v.make,
                                models = from m in v.model
                                         orderby v.model.Distinct()
                                         select new {


                                         
                             }
            
                            */

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}