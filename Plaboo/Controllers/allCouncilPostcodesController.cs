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

        // GET: This is a GET http method to get all the allCouncilPostcodes
        public ActionResult Index()
        {
            return View(db.allCouncilPostcodes.ToList());
        }

       //to dispose off the object
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
