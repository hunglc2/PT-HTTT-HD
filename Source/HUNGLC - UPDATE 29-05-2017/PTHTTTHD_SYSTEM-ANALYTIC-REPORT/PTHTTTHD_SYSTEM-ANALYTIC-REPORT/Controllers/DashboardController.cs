using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTHTTTHD_SYSTEM_ANALYTIC_REPORT.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dashboard01()
        {
            ViewBag.Message = "Your test page.";

            return View();
        }

        public ActionResult Dashboard02()
        {
            ViewBag.Message = "Your test page.";

            return View();
        }
    }
}