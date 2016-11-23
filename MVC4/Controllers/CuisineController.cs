using MVC4.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC4.Controllers
{
    [Log]
    public class CuisineController : Controller
    {
        public ActionResult Search(string name = "French")
        {
            //throw new Exception("Something terrible has happened.");

            var message = Server.HtmlEncode(name);

            return Content(string.Format("You were looking up {0}.", message));
            //return File(Server.MapPath("~/Content/site.css"), "text/css");
            //return Json(new { Message = message, Name = "Andrew" }, JsonRequestBehavior.AllowGet);
        }
    }
}