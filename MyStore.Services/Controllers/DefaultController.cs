using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyStore.Services.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Welcome()
        {
            ViewBag.Title = "My Store API";

            return View();
        }
    }
}
