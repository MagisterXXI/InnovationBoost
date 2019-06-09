using InnovationBoost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackatonCyberGo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var kernel = GetKernel();
            ViewBag.Problems = kernel.Problems;
            ViewBag.Business = kernel.Businesses[0];
            return View("StudentView");
        }

        private Kernel GetKernel()
        {
            return Session["kernel"] as Kernel;
        }
    }
}