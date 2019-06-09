using InnovationBoost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackatonCyberGo.Controllers
{
    public class BusinessController : Controller
    {
        // GET: Busines
        public ActionResult Index()
        {
            var kernel = GetKernel();
            ViewBag.Problems = kernel.Problems;
            return View("BusinessView");
        }

        private Kernel GetKernel()
        {
            return Session["kernel"] as Kernel;
        }
    }
}