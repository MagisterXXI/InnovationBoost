using InnovationBoost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackatonCyberGo.Controllers
{
    public class ProblemsController : Controller
    {
        // GET: Problems
        public ActionResult Index()
        {
            ViewBag.UrlImage = "Irrigation-system.jpg";
            return View("ProblemsView");
        }

        public ActionResult Problem()
        {
            var kernel = GetKernel();
            ViewBag.Business = kernel.Businesses[0];
            return View("ProblemView");
        }

        private Kernel GetKernel()
        {
             return Session["kernel"] as Kernel;
        }
    }
}