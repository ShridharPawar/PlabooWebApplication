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
        public ActionResult LogOn()
        {
            LogOnViewModel model = new LogOnViewModel();

            return View(model);
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult LogOn(LogOnViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.UserName, false);
                return RedirectToAction("Index", "Home");
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

        public ActionResult LogOff()
        {
            Request.Cookies.Remove("UserName");
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}