using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
    class Program
    {
        delegate void Sorting(string[] array, SortDirection sd);

        delegate bool SortDirection(int a, int b);

        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string input = Console.ReadLine();
            string[] array1 = Regex.Split(input, @"\s");

            Sorting sorting1 = StringSorting;

            sorting1(array1, IsGreater);



            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            Console.ReadKey();
        }

         static void StringSorting(string[] array, SortDirection sd)
         {
             string temp;
             for (int i = 0; i < array.Length - 1; i++)
             {
                 for (int j = i + 1; j < array.Length; j++)
                 {
                     if (sd (array[i].Length , array[j].Length))
                     {
                         temp = array[i];
                         array[i] = array[j];
                         array[j] = temp;
                     }
                     if (array[i].Length == array[j].Length)
                     {
                      //   if 
                     }
                 }
             }
         }

        static bool IsGreater (int a, int b)
        {
            return a > b;
        }

       /* static string[] StringSorting(string[] array)
        {
            var query = (from arr in array
                         orderby arr.Length, arr.Substring(0, 1)
                         select arr).ToArray();

            return query;
        }*/
    }
}
