using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
		public static int TaskFactorial(int number)
		{
			int temporary = 1;
			for (int i =1; i <= number; i++)
			{
				temporary = temporary * i;
			}
			return temporary;
		}

		public static int TaskToAPower(int number1, int number2)
		{
			int temporary = 1;
			for (int i = 0; i < number2; i++)
			{
				temporary = temporary * number1;
			}
			return temporary;
		}
    }
}
