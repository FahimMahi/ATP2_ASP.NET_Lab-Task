using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace atp1_1st.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Hello!";

            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "My Education";

            return View();
        }

        public ActionResult PersonalDetails()
        {
            ViewBag.Message = "My Personal Details";

            return View();
        }
        public ActionResult Projects()
        {
            ViewBag.Message = "My Projects";

            return View();
        }
        public ActionResult References()
        {
            ViewBag.Message = "References";

            return View();
        }
    }
}