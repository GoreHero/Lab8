using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.
namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\K.Zaitsev\Documents\Temp";
            string[] files = Directory.GetFiles(path,"*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}