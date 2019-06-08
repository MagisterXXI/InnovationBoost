using InnovationBoost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HackatonCyberGo.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult Index()
        {

            return View("GroupView");
        }

        private Kernel GetKernel()
        {
            return Session["kernel"] as Kernel;
        }
    }
}