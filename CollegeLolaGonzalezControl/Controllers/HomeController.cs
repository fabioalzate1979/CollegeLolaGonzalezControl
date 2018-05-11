using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CollegeLolaGonzalezControl.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult IngresoCalificacion()
        {
            return View();
        }

        [HttpPost]
        public ActionResult IngresoCalificacion(string Data) {

            return View();
        }
    }
}