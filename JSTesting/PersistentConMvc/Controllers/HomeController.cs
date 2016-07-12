using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersistentConMvc.Controllers
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
            var dir = new DirectoryInfo("~/Images/Weddings");// папка с файлами 
            var files = new List<string>(); // список для имен файлов 
            foreach (FileInfo file in dir.GetFiles()) // извлекаем все файлы и кидаем их в список 
            {
                files.Add(file.FullName); // получаем полный путь к файлу и кидаем его в список 
            }

            return View(files);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}