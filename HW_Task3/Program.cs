using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, которая выводит статистику по файлу - количество символов, строк и слов в тексте.

namespace HW_Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\K.Zaitsev\Documents\Temp\test.txt";
            int countChar = 0;
            int countString = 0;
            int countWord = 0;


            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    countChar+= line.Length;
                    countString += 1;
                    countWord += line.Split(' ').Length;
                }
            }
            Console.WriteLine("в тексте {0} символов", countChar);
            Console.WriteLine("в тексте {0} строк", countString);
            Console.WriteLine("в тексте {0} слов", countWord);
            Console.ReadKey();
        }
    }
}

