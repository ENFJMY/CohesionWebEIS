using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CohesionWebEIS.Controllers
{
    public class HomeController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            if (Session["userInfo"]==null)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}