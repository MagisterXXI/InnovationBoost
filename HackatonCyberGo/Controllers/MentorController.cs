﻿using InnovationBoost;
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
            ViewBag.Problems = kernel.Problems;
            return View("MentorView");
        }

        public ActionResult MentorProfile()
        {
            var kernel = GetKernel();
            ViewBag.Problems = kernel.Problems;
            return View("MentorProfileView");
        }


        private Kernel GetKernel()
        {
            return Session["kernel"] as Kernel;
        }
    }
}