using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                insuree.Quote = CreateQuote(insuree);
                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        private decimal CreateQuote(Insuree insuree)
        {
            // start with a base of 50/mo.
            decimal quote = 50;
            quote += GetAgeAdjustment(insuree.DateOfBirth);
            quote += GetCarYearAdjustment(insuree.CarYear);
            quote += GetMakeModelAdjustment(insuree.CarMake, insuree.CarModel);
            quote += insuree.SpeedingTickets * 10;
            if (insuree.DUI) quote *= 1.25m;
            if (insuree.CoverageType) quote *= 1.5m;

            return quote;
        }

        private int GetAgeAdjustment(DateTime dob)
        {
            // converts age to an int from dob DateTime
            int age = new DateTime(DateTime.Now.Subtract(dob).Ticks).Year - 1;
            int adjustment = 0;

            // if age is under 18 add 100
            if (age <= 18) adjustment += 100;

            // if age is between 19 - 25, add 50
            else if (19 <= age && age <= 25) adjustment += 50;

            // if age is older than 25, add 25
            else adjustment += 25;
            return adjustment;
        }
        private int GetCarYearAdjustment(int carYear)
        {
            int adjustment = 0;

            // if car year is before 2000 or after 2015, add 25
            if (carYear < 2000 || carYear > 2015) adjustment += 25;

            return adjustment;
        }
        private int GetMakeModelAdjustment(string make, string model)
        {
            int adjustment = 0;

            // if make is Porsche add 25 and if it's also a 911 Carrera add another 25
            if (make == "Porsche" && model == "911 Carrera") adjustment += 50;
            else if (make == "Porsche") adjustment += 25;

            return adjustment;
        }

        // add admin view that shows all quotes
        public ActionResult admin()
        {
            var quoteList = new List<Insuree>();
            using (InsuranceEntities db = new InsuranceEntities())
            {
                quoteList = db.Insurees.ToList();
            }

            return View(quoteList);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
