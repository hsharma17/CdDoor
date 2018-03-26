using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YourNest.Controllers
{
    public class OwnerController : Controller
    {
        //
        // GET: /Owner/

       

        public ActionResult submitNewProperty()
        {
            return View();
        }

        public ActionResult getpropertylistPartial()
        {
            return View();
        }
    }
}
