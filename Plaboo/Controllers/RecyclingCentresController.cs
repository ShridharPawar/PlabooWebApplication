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
    public class RecyclingCentresController : Controller
    {
        private PlabooContext db = new PlabooContext();

        // GET: RecyclingCentres
        public ActionResult Index()
        {
            return View(db.RecyclingCentres.ToList());
        }

        // GET: RecyclingCentres/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RecyclingCentre recyclingCentre = db.RecyclingCentres.Find(id);
            if (recyclingCentre == null)
            {
                return HttpNotFound();
            }
            return View(recyclingCentre);
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
