using InnovationBoost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackatonCyberGo.Controllers
{
    public class MentorController : Controller
    {
        // GET: Mentor
        public ActionResult Index()
        {
            var kernel = GetKernel();
            ViewBag.Businesses = kernel.Businesses;
            return View("MentorView");
        }

        private Kernel GetKernel()
        {
            return Session["kernel"] as Kernel;
        }
    }
}