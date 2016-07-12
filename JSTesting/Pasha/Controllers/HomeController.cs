using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pasha.Constants;
using Pasha.Helper;
using Pasha.Models;

namespace Pasha.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Weddings()
        {
            return View(CodeHelper.GetFileNames(@"C:\Users\Alexandr_Digilevich\Source\Repos\FinalProject\JSTesting\Pasha\Images\Weddings"));
        }

        public ActionResult Preview(string name)
        {
            var files = CodeHelper.GetFileNames(PashaConstants.ImagesPath);

            PreviewModel previewModel = new PreviewModel() {Name = name, Count = files.Count.ToString(), Number = files.IndexOf(name).ToString()};

            return View(previewModel);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}