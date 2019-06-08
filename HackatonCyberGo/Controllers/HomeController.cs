using InnovationBoost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackatonCyberGo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var kernel = GetKernel();
            ViewBag.Businesses = kernel.Businesses;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Empty()
        {
            ViewBag.Message = "Извитине, страницы пока нет.";

            return View("EmptyView");
        }

        public ActionResult Presentation()
        {
            ViewBag.Message = "Тут должен быть прекрасный презентационный ролик на 3 минуты о работе платформы.";

            return View("EmptyView");
        }

        private Kernel GetKernel()
        {
            return Session["kernel"] as Kernel;
        }
    }
}