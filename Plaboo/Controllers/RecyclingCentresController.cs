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
        private PlabooContext db = new PlabooContext();   //db context instance

        //GET: RecyclingCentres
        //This will return all distinct suburbs of the recycling centers to shpw it to the users using mapbox
        public ActionResult Index()
        {
            ViewBag.availabletags = db.RecyclingCentres.Select(x => x.Postcode).Distinct().ToList().ToArray(); //used LINQ to select the distinct
            //suburbs from the database and pass it to the view to show them
            return View(db.RecyclingCentres.ToList()); //return the model to the view

        }

        //action for suburb autocomplete
        public List<string> AutoComplete()
        {
            return db.RecyclingCentres.Select(x => x.Postcode).ToList();  //return all suburbs for jquery autocomplete

        }

        //action to return the recycling centers of the searched suburb
        [HttpPost]
        public ActionResult Index(FormCollection formcollection)
        {
            var postcodestring = formcollection["postcode"];  //suburb as a string from the formcollection variable
            ViewBag.availabletags = db.RecyclingCentres.Select(x => x.Postcode).Distinct().ToList().ToArray();  //used LINQ to select the distinct
            //suburbs from the database and pass it to the view to show them 
            if (postcodestring == "") //if the suburb is not searched then return all recycling centers
            {
                return View(db.RecyclingCentres.ToList());  //return all recycling centers to the model
            }
            else 
            {
                return View(db.RecyclingCentres.Where(x => x.Postcode == postcodestring).ToList());  //if the suburb is found then return 
                //nearby recycling centers
            }
          
           

        }


       //action to dispose
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
