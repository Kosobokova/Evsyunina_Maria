using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            for (int i=1; i<1000; i++)
            {
                if (i % 3 == 0 || i % 5 ==0)
                {
                   int b = a + i;
                    a = b;
                }

            }
            Console.WriteLine($"Сумма всех чисел меньше 1000, кратных 3, или 5 равна {a}");
            Console.ReadKey();
        }
    }
}
