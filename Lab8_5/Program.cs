using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_5
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
                IEnumerable<string> files = Directory.EnumerateFileSystemEntries(path);
                foreach (string s in files)
                    Console.WriteLine(s);

            }
            Console.ReadKey();
        }
    }
}
