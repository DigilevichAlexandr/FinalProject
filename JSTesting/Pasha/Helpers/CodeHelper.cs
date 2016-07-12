using System.Collections.Generic;
using System.IO;

namespace Pasha.Helper
{
    public static class CodeHelper
    {
        public static List<string> GetFileNames(string path)
        {
            var dir = new DirectoryInfo(path); // папка с файлами 
            var files = new List<string>(); // список для имен файлов 
            foreach (FileInfo file in dir.GetFiles()) // извлекаем все файлы и кидаем их в список 
            {
                files.Add(file.Name); // получаем полный путь к файлу и кидаем его в список 
            }

            return files;
        }
    }
}