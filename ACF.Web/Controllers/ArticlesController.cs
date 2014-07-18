using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ACF.Web.Controllers
{
    public class ArticlesController : Controller
    {
        [AllowAnonymous]
        [Route("Articles/Samir/2014-09-06")]
        public ActionResult Sample1()
        {
            return View("~/Views/Articles/Samir/2014-09-06.cshtml");
        }

        [Route("Articles/Samir/2014-09-04")]
        public ActionResult Sample2()
        {
            return View("~/Views/Articles/Samir/2014-09-06.cshtml");
        }

        [Authorize(Roles="Subscriber")]
        public ActionResult View(string author, string title)
        {
            var viewPath = String.Format("~/Views/Articles/{0}/{1}", author, title);
            return View(viewPath);
        }
	}
}