using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{

    class TwoDPoint : Object
    {
        public readonly int x, y;

        public TwoDPoint(int x, int y)  //constructor
        {
            this.x = x;
            this.y = y;
        }
    }


    class TwoDPointWithHash : TwoDPoint
    {
        public TwoDPointWithHash(int x, int y) : base(x, y)
        { }

        public override int GetHashCode()
        {
            int newx = x * x + y * y * y;

            int temp = newx >> 1;
            return temp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var points = new List<TwoDPointWithHash>();
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    points.Add(new TwoDPointWithHash(i, j));
                }
            }

            var hashes = new List<int>();
            foreach (var point in points)
            {
                hashes.Add(point.GetHashCode());
            }

            double uniqueHashesCount = hashes.Distinct().ToList().Count;
            double result = (uniqueHashesCount / points.Count) * 100;

            //int[] hashes = new int[1000];
            //for (int i = 0; i < 1000; i++)
            //{
            //    hashes[i] = points[i, 0] * points[i, 1];
            //    hashes[i] = hashes[i] >> hashes[i];
            //}

            //string[] test = new string[1000];
            //for (int i = 0; i < 1000; i++)
            //{
            //    test[i] = points[i, 0] + "," + points[i, 1];
            //}


            //var result = test.Distinct();

            //int resultLength = 0;
            //foreach (string i in result)
            //{
            //    resultLength++;
            //}

            //Console.WriteLine(resultLength);

            //var result2 = hashes.Distinct();
            //int result2Length = 0;
            //foreach (string i in result)
            //{
            //    result2Length++;
            //}

            //Console.WriteLine(result2Length);
            //Console.ReadKey();
        }
    }
}
