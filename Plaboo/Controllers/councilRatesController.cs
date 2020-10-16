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

        // this method takes the 'postcode' as input from the user and finds the ranking and recycling rate of the council
        //to which that postcode belongs
        public ActionResult RatePartial(string searchText)
        {
            //the ranking of the council is fetched from the database using a LINQ query based on the 'postcode' received as a parameter
            //from the user. viewbag is used to pass the data to the view
            ViewBag.Rank = db.councilRates.Where(x => x.council.Equals(searchText)).Select(x=>x.rank).FirstOrDefault();
            //the recycling rate of the council is fetched from the database using a LINQ query based on the 'postcode' received as a parameter
            //from the user. viewbag is used to pass the data to the view
            ViewBag.Rate = db.councilRates.Where(x => x.council.Equals(searchText)).Select(x => x.rate).FirstOrDefault();
            //viewbag is created to pass the council to the view
            ViewBag.Council = searchText;
            //partialview is returned to show the details of the council
            return PartialView();
        }


       // this is a GET HTPP method to get the details of councils- like their rank, recycling rate etc
       public ActionResult Index()
        {
            return View(db.councilRates.ToList());  //return all councilrates to the model
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
