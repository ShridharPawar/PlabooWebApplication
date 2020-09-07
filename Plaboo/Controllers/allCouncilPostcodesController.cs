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
    public class allCouncilPostcodesController : Controller
    {
        private PlabooContext db = new PlabooContext();

        // GET: allCouncilPostcodes
        public ActionResult Index()
        {
            return View(db.allCouncilPostcodes.ToList());
        }

        // GET: allCouncilPostcodes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            allCouncilPostcode allCouncilPostcode = db.allCouncilPostcodes.Find(id);
            if (allCouncilPostcode == null)
            {
                return HttpNotFound();
            }
            return View(allCouncilPostcode);
        }

        // GET: allCouncilPostcodes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: allCouncilPostcodes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "postcode,council")] allCouncilPostcode allCouncilPostcode)
        {
            if (ModelState.IsValid)
            {
                db.allCouncilPostcodes.Add(allCouncilPostcode);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(allCouncilPostcode);
        }

        // GET: allCouncilPostcodes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            allCouncilPostcode allCouncilPostcode = db.allCouncilPostcodes.Find(id);
            if (allCouncilPostcode == null)
            {
                return HttpNotFound();
            }
            return View(allCouncilPostcode);
        }

        // POST: allCouncilPostcodes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "postcode,council")] allCouncilPostcode allCouncilPostcode)
        {
            if (ModelState.IsValid)
            {
                db.Entry(allCouncilPostcode).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(allCouncilPostcode);
        }

        // GET: allCouncilPostcodes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            allCouncilPostcode allCouncilPostcode = db.allCouncilPostcodes.Find(id);
            if (allCouncilPostcode == null)
            {
                return HttpNotFound();
            }
            return View(allCouncilPostcode);
        }

        // POST: allCouncilPostcodes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            allCouncilPostcode allCouncilPostcode = db.allCouncilPostcodes.Find(id);
            db.allCouncilPostcodes.Remove(allCouncilPostcode);
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
