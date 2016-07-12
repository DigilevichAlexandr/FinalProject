using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SignalRMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Galery()
        {
            var files = new DirectoryInfo(@"C:\Users\Alexandr_Digilevich\Source\Repos\FinalProject\JSTesting\SignalRMvc\Images");
            List<string> names = new List<string>();
            foreach (var file in files.GetFiles())
            {
                names.Add(file.Name);
            }

            return View(names);
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