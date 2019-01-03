using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_filters_partialview_csrf.Controllers
{
    [HandleError( View = "error")]
    public class homeController : Controller
    {
        [OutputCache(Duration =30)]//Filter
        public ActionResult getdetails()
        {
            ViewBag.msg = DateTime.Now.ToString();
            return View();
        }

        [HandleError(ExceptionType =typeof(DivideByZeroException),View ="myerror")]
        public ActionResult getupdate()
        {
            int x = 100;
            int y = 0;
            int total = x / y;
            return View();
        }
    }
}