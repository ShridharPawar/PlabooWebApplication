using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Plaboo.Controllers
{
   //[Authorize]
    public class HomeController : Controller
    {

        public ActionResult Quiz()
        {
            return View();
        }


        //this is the HTTP get method to retreive the 'Recycling Suggestions' page
        public ActionResult RecyclingSuggestions()
        {
            return View();
        }
       

        //this is the HTTP get method to retreive the main home page screen which is shown to the user when the user starts accessing the website
        public ActionResult Index()
        {
            return View();
        }

       
    }
}