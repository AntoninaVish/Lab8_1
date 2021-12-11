using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\79602\source\repos";
            DirectoryInfo dir = new DirectoryInfo(path);
            foreach (string item in dir.GetDirectories());
            {
                Console.WriteLine(item);
            }
        }
    }
}
