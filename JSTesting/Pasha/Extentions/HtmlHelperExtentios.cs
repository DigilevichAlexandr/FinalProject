using System.Collections.Generic;
using System.IO;
using System.Web.Mvc;

namespace Pasha.Extentions
{
    public static class HtmlHelperExtentios
    {
        public static MvcHtmlString ActionLinkImage(this HtmlHelper helper, string src, string url, string cssClass)
        {
            var href = new TagBuilder("a");
            href.MergeAttribute("href", url);

            if (!string.IsNullOrEmpty(cssClass))
                href.AddCssClass(cssClass);

            var img = new TagBuilder("img");
            img.MergeAttribute("src", src);

            href.InnerHtml = img.ToString(TagRenderMode.SelfClosing);

            return MvcHtmlString.Create(href.ToString(TagRenderMode.Normal));
        }

        public static string GetNameByNumber(this HtmlHelper helper, int number)
        {
            var dir = new DirectoryInfo(@"C:\Users\Alexandr_Digilevich\Source\Repos\FinalProject\JSTesting\Pasha\Images\Weddings"); // папка с файлами 
            var files = new List<string>(); // список для имен файлов 
            foreach (FileInfo file in dir.GetFiles()) // извлекаем все файлы и кидаем их в список 
            {
                files.Add(file.Name); // получаем полный путь к файлу и кидаем его в список 
            }

            return files[number];
        }
    }
}