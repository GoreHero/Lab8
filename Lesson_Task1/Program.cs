using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo d in drives)
            {
                if (d.IsReady)
                {
                    Console.WriteLine("Название: {0}", d.Name);
                    if (d.IsReady)
                    {
                        Console.WriteLine("объем диска: {0}", d.TotalSize);
                        Console.WriteLine("Свободно: {0}", d.AvailableFreeSpace);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }
    }
}
