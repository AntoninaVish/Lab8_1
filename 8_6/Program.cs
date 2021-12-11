using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\79602\source\repos";

            DirectoryInfo directory = new DirectoryInfo(path);
            if (directory.Exists)
            {
                Console.WriteLine("Содержимое папки:");
                string[]=directory.GetDirectories();
                foreach (string dir in directory)
                {
                    Console.WriteLine(dir);
                }
            }
            Console.ReadKey();
        }
    }
}
