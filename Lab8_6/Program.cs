using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Lab8_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] direct;
            string path = @"C:\Users\79602\source\repos";

            if (Directory.Exists(path))
            {
                Console.WriteLine("Содержимое папки:");
                
                string[] dirs = Directory.GetFileSystemEntries(path);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                
                        direct = Directory.GetFileSystemEntries(s);
                        {
                            foreach (string sd in direct)
                                Console.WriteLine(sd);
                        }
                    
                }
                Console.ReadKey();
            }
        }
    }
}
