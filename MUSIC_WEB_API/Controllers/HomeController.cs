using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http.Tracing; // 
using System.Web.Http; // enable Microsoft Asp Net Web Api Core Client for Library Development



namespace MUSIC_WEP_API.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
