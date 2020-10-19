using Microsoft.Azure;
using Plaboo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Plaboo.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        //this method is to get the view of the password protection functionality
        public ActionResult LogOn()
        {
            LogOnViewModel model = new LogOnViewModel();

            return View(model);
        }

        //this method is to post the data of the password protection functionality to check if the username and password
        //given by the user are correct
        [AllowAnonymous]
        [HttpPost]
        public ActionResult LogOn(LogOnViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("Index", "Home");
                //the follwing code checks if the entered username and password are correct
                //if (model.UserName == CloudConfigurationManager.GetSetting("UName") && model.Password == CloudConfigurationManager.GetSetting("UPw"))
                //{
                //    FormsAuthentication.SetAuthCookie(model.UserName, false);
                //    return RedirectToAction("Index", "Home");

                //}
                //else
                //{
                //    ModelState.AddModelError("", "Incorrect username or password");
                //}
            }

            return View(model);
        }

        //this is to let the user logoff from the website
        public ActionResult LogOff()
        {
            Request.Cookies.Remove("UserName");
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}