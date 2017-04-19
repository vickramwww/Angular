using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularDemo.Controllers
{

    public class Demo
    {
        public int no;
        public string Name;
    }


    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Demo> d = new List<Demo>();

            d.Add(new Demo { Name="Vickram", no=1 });
            d.Add(new Demo { Name = "Vickram1", no = 2 });

            return View(d);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}