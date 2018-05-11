using CollegeLolaGonzalezControl.Models.Security;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace CollegeLolaGonzalezControl.Controllers

{


    public class SecurityController : Controller
    {

        IAuthenticationManager Authentication
        {
            get { return HttpContext.GetOwinContext().Authentication; }
        }

        // GET: Security
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(LoginInputModel model)
        {
            return View(model);

        }


  
        public ActionResult Logout()
        {
            Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
            return RedirectToAction("Index", "Home");
        }

    }
}