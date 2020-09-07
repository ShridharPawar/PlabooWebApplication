using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Plaboo.Context;
using Plaboo.Models;

namespace Plaboo.Controllers
{
    public class councilRatesController : Controller
    {
        private PlabooContext db = new PlabooContext();

        public ActionResult RatePartial(string searchText)
        {
            ViewBag.Rank = db.councilRates.Where(x => x.council.Equals(searchText)).Select(x=>x.rank).FirstOrDefault();
            ViewBag.Rate = db.councilRates.Where(x => x.council.Equals(searchText)).Select(x => x.rate).FirstOrDefault();
            return PartialView();
        }


        // GET: councilRates
        public ActionResult Index()
        {
            return View(db.councilRates.ToList());
        }

        // GET: councilRates/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            councilRate councilRate = db.councilRates.Find(id);
            if (councilRate == null)
            {
                return HttpNotFound();
            }
            return View(councilRate);
        }

        // GET: councilRates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: councilRates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "council,rate,rank")] councilRate councilRate)
        {
            if (ModelState.IsValid)
            {
                db.councilRates.Add(councilRate);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(councilRate);
        }

        // GET: councilRates/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            councilRate councilRate = db.councilRates.Find(id);
            if (councilRate == null)
            {
                return HttpNotFound();
            }
            return View(councilRate);
        }

        // POST: councilRates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "council,rate,rank")] councilRate councilRate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(councilRate).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(councilRate);
        }

        // GET: councilRates/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            councilRate councilRate = db.councilRates.Find(id);
            if (councilRate == null)
            {
                return HttpNotFound();
            }
            return View(councilRate);
        }

        // POST: councilRates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            councilRate councilRate = db.councilRates.Find(id);
            db.councilRates.Remove(councilRate);
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
