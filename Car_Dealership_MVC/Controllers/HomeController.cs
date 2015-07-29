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

namespace Car_Dealership_MVC.Controllers
{
    public class HomeController : Controller
    {
        private DealershipContext db = new DealershipContext(); 
        public ActionResult Index()
        {
            List<Customer> customerList = new List<Customer>();

            //var q = from c in db.users
            //        orderby c.UserName
            //        select c;
            return View(db.users.ToList());
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