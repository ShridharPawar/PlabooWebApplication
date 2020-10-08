﻿using System;
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

        //GET: RecyclingCentres
        public ActionResult Index()
        {
            ViewBag.availabletags = db.RecyclingCentres.Select(x => x.Suburb).Distinct().ToList().ToArray();
            return View(db.RecyclingCentres.ToList());

        }

        public List<string> AutoComplete()
        {
            return db.RecyclingCentres.Select(x => x.Suburb).ToList();

        }

        [HttpPost]
        public ActionResult Index(FormCollection formcollection)
        {
            var suburbstring = formcollection["suburb"];
            ViewBag.availabletags = db.RecyclingCentres.Select(x => x.Suburb).Distinct().ToList().ToArray();
            if (suburbstring == "")
            {
                return View(db.RecyclingCentres.ToList());
            }
            else 
            {
                return View(db.RecyclingCentres.Where(x => x.Suburb == suburbstring).ToList());
            }
          
           

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
