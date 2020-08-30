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
    [RequireHttps]
    public class AlternativesController : Controller
    {
        private PlabooContext db = new PlabooContext();

        // GET: Alternatives
        public ActionResult Index()
        {
            return View(db.Plastics.ToList());
        }

        // GET: Alternatives/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plastic plastic = db.Plastics.Find(id);
            if (plastic == null)
            {
                return HttpNotFound();
            }
            return View(plastic);
        }

        // GET: Alternatives/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alternatives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Plasticid,Description,Alternative,Reason,Image,Harmindex")] Plastic plastic)
        {
            if (ModelState.IsValid)
            {
                db.Plastics.Add(plastic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(plastic);
        }

        // GET: Alternatives/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plastic plastic = db.Plastics.Find(id);
            if (plastic == null)
            {
                return HttpNotFound();
            }
            return View(plastic);
        }

        // POST: Alternatives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Plasticid,Description,Alternative,Reason,Image,Harmindex")] Plastic plastic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(plastic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(plastic);
        }

        // GET: Alternatives/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Plastic plastic = db.Plastics.Find(id);
            if (plastic == null)
            {
                return HttpNotFound();
            }
            return View(plastic);
        }

        // POST: Alternatives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Plastic plastic = db.Plastics.Find(id);
            db.Plastics.Remove(plastic);
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
