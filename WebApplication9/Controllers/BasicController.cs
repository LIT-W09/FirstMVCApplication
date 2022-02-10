using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication9.Controllers
{
    public class BasicController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OtherStuff()
        {
            return View();
        }
    }

    //create a simple MVC application with the following pages:

    // /Home/PageOne - this page should have a link to /home/pagetwo 
    // /Home/PageTwo - this page should have a link to /home/pageone

    // /Other/First - this page should have a link to goolge
}