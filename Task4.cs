using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace Task4

{

    class Program

    {

        static void Main(string[] args)

        {

            int n = 0;

            while (n == 0)

            {

                Console.WriteLine("Введите количеcтво строк");

                string a = Console.ReadLine();

                bool b = int.TryParse(a, out n);

                if (b == true && n > 0)

                {

                    Console.WriteLine($"Количество строк {n}");
                    
                }

                else

                    Console.WriteLine("Некорректное значение!");

            }
            string str = "*";

            int b1 = n + 1;

            string b2 = str.PadLeft(b1);

            Console.WriteLine(b2);

            for (int j = 1; j < n; j++)
            {

                str = "*";

                b1 = n + 1;

                b2 = str.PadLeft(b1);

                Console.WriteLine(b2);

                for (int i = 1; i < j+1; i++)

                {

                    string b3 = b2.Remove(0, 1) + "**";

                    b2 = b3;

                    Console.WriteLine(b2);

                }
            }

                Console.ReadKey();
            
        }

    }

}