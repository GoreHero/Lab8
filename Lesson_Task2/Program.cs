using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "Logs2/log.txt";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //DirectoryInfo directory = new DirectoryInfo(path);
            //if (!directory.Exists)
            //{
            //    directory.Create();
            //}
            /*if (!File.Exists(path))
            {
                File.Create(path);
            }*/
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("Старт программы");
                sw.WriteLine("Ошибка");                
            }
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
