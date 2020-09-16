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

        // GET: This is a get method to get all details of the plastic items in the database
        public ActionResult Index()
        {
            return View(db.Plastics.ToList());
        }


       //to dispose off
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
