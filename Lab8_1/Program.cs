using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\79602\source\repos";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Содержимое папки:");
                IEnumerable<string> files = Directory.EnumerateFileSystemEntries(path);
                foreach (string s in files)
                Console.WriteLine(s);
                Console.WriteLine("Содержимое подкаталогов:");
                string[] dirs = Directory.GetDirectories(path);
                foreach (string s in dirs)
                {
                    string[] subdirs = Directory.GetFileSystemEntries(s);
                    foreach (string sd in subdirs)
                    {
                        Console.WriteLine(sd);
                    }
                }
                Console.ReadKey();
            }

        }
       
    }      
}