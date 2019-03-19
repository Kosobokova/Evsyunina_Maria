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
            Console.WriteLine("Введите первую строку");

            string string1 = Console.ReadLine();

            Console.WriteLine($"Первая строка: {string1}");

            Console.WriteLine("Введите вторую строку");

            string string2 = Console.ReadLine();

            Console.WriteLine($"Вторая строка: {string2 }");

            StringBuilder stringBuilder1 = new StringBuilder(string1);

            for (int i = 0; i < stringBuilder1.Length; i++)
            {
                if (string2.Contains(stringBuilder1[i]))
                {
					stringBuilder1.Insert(i, stringBuilder1[i]);
                    i++;
                }
            }
            Console.WriteLine(stringBuilder1.ToString());
            Console.ReadKey();
        }
    }
}
