using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourNest.Controllers
{
    public class CommonController : Controller
    {
        //
        // GET: /Common/

        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult ViewprofilePartial()
        {

            return View();
        }
    }
}
