using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace WebAPIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index1()
        {
            return View();
        }
        public ActionResult us()
        {
            return View();
        }
        public ActionResult resources()
        {
            return View();
        }
        public ActionResult news()
        {
            return View();
        }

    }
}