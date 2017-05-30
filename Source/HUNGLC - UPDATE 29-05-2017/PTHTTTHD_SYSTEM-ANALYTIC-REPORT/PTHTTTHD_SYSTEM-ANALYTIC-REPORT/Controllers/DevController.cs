using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PTHTTTHD_SYSTEM_ANALYTIC_REPORT.Controllers
{
    public class DevController : Controller
    {
        // GET: Dev
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Dev01()
        {
            ViewBag.Message = "Your test page.";
            return View();
        }

        public ActionResult Dev02()
        {
            ViewBag.Message = "Your test page.";
            return View();
        }
    }
}