using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\K.Zaitsev\Documents\Temp";
            string[] files = Directory.GetFiles(path,"*.txt",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
