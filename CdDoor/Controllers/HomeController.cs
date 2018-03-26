using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourNest.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult search_properties()
        {
            return View();
        }

        public ActionResult show_property()
        {
            return View();
        }

        public ActionResult contactus()
        {
            return View();
        }

        public ActionResult show_propertiesPartial()
        {
            return View();
        }

        public ActionResult howitworksPartial()
        {
            return View();
        }
        public ActionResult advance_searchPartial()
        {
            return View();
        }

        public ActionResult recent_propertiesPartial()
        {
            return View();
        }

        public ActionResult latest_reviewsPartial()
        {
            return View();
        }

        public ActionResult propertiesnearby()
        {
            return View();
        }

        public ActionResult aboutusPartial()
        {
            return View();
        }
    }
}
