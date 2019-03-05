using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = 0;
            while (n==0)
            { Console.WriteLine("Введите количеcтво строк");
                string a = Console.ReadLine();
                bool b = byte.TryParse(a, out n);
                if (b == true && n > 0)
                {
                    Console.WriteLine($"Количество строк {n}");

                }
                else
                    Console.WriteLine("Некорректное значение!");
            }
            string s1 = "";
            for (int i = 0; i < n; i++)
            {
                string s2 = s1+"*";
                s1 = s2;
                Console.WriteLine(s1);
            }
            Console.ReadKey();
        }
    }
}
