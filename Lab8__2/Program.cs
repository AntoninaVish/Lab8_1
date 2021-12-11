using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8__2
{
    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();
            

            string path = "Logs3/Log2.txt";//Создаем текстовый файл
            if (!File.Exists(path))
            {
                File.Create(path);
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int x = random.Next(0, 10);
                    sw.WriteLine(x);
                }
            }
            int s = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    int x = Convert.ToInt32(sr.ReadLine());
                    s += x;
                }
            }
            Console.WriteLine("Сумма 10 случайных чисел: {0}.", s);
            Console.ReadKey();
        }       
    }
    
       
    
}
