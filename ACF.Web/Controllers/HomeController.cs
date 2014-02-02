using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACF.Web.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("About")]
        public ActionResult About()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("Instructors")]
        public ActionResult Instructors()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("Schools")]
        public ActionResult Schools()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("Insurance")]
        public ActionResult Insurance()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("FAQ")]
        public ActionResult FAQ()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("Privacy")]
        public ActionResult Privacy()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("Terms")]
        public ActionResult Terms()
        {
            return View();
        }

        [AllowAnonymous]
        [Route("Samples")]
        public ActionResult Samples()
        {
            return View();
        }
    }
}