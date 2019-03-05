using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        { uint l =0;
            uint w=0;
            while (l == 0)
            {
                Console.WriteLine("Введите длину прямоугольника");
                string a = Console.ReadLine();
                bool aa = uint.TryParse(a, out l);
                if (aa == true && l > 0)
                {
                    Console.WriteLine($"Длина прямоугольника {l}");
                    
                }
                else
                    Console.WriteLine("Некорректное значение!");
            }
            while (w == 0)
            {
                Console.WriteLine("Введите ширину прямоугольника");
                string b = Console.ReadLine();
                bool bb = uint.TryParse(b, out w);
                if (bb == true && w > 0)
                    Console.WriteLine($"Ширина прямоугольника {w}");
                else
                    Console.WriteLine("Некорректное значение!");
            }
            uint ar = l * w;
            Console.WriteLine($"Площадь прямоугольника {ar}");
            Console.ReadKey();
        }
    }
}
