using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Car_Dealership_MVC.Models;
using Car_Dealership_MVC.DAL;

namespace Car_Dealership_MVC.Controllers
{
    public class VehiclesController : Controller
    {
        public DealershipContext db = new DealershipContext();

        // GET: Vehicles
        public ActionResult Index(string searchString, string sortBy)
        {
            var modelList = new List<string>();
            var makeList = new List<string>();
            var colorList = new List<string>();
            var msrpList = new List<string>();

            var model = from car in db.inventory
                        orderby car.model                       
                        select car.model;

            var make = from car in db.inventory
                        orderby car.make
                        select car.make;

            var color = from car in db.inventory
                        orderby car.color
                        select car.color;

            var msrp = from car in db.inventory
                        orderby car.MSRP
                        select car.MSRP.ToString();


            modelList.AddRange(model.Distinct());
            makeList.AddRange(make.Distinct());
            msrpList.AddRange(msrp.Distinct());
            colorList.AddRange(color.Distinct());

            ViewBag.carModel = new SelectList(modelList);
            ViewBag.carMake = new SelectList(makeList);
            ViewBag.carColor = new SelectList(colorList);
            ViewBag.carMSRP = new SelectList(msrpList);


            var cars = from car in db.inventory
                       select car;

            if (!String.IsNullOrEmpty(searchString) && sortBy == "MSRP")
            {
                cars = cars.Where(s => s.MSRP.ToString().Contains(searchString));
            }
            if (!String.IsNullOrEmpty(searchString) && sortBy == "color")
            {
                cars = cars.Where(s => s.color.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(searchString) && sortBy == "make")
            {
                cars = cars.Where(s => s.make.Contains(searchString));
            }
            if (!String.IsNullOrEmpty(searchString) && sortBy == "model")
            {
                cars = cars.Where(s => s.model.Contains(searchString));
            }
           

            return View(cars);
        }

        // GET: Vehicles/Details/5
        public ActionResult Details(int id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.inventory.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,VIN,make,model,year,MPG,color,MSRP")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.inventory.Add(vehicle);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.inventory.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,VIN,make,model,year,MPG,color,MSRP")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.inventory.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Vehicle vehicle = db.inventory.Find(id);
            db.inventory.Remove(vehicle);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        
    }
}
