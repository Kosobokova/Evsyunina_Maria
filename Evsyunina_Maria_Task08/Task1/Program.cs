using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class DynamicArray<T> 
	{
		private T[] innerArray; //собственно массив

		//private int length;

		public DynamicArray() //Конструктор без параметров (создается массив емкостью 8 элементов)

		{
			innerArray = new T[8];
			//length = 0;
		}

		public DynamicArray(int elementsCount) //Конструктор с 1 целочисленным параметром (создается массив заданной емкости)
		{
			innerArray = new T[elementsCount];
			//length = 0;
		}

		public DynamicArray(T[] series) //Конструктор, который в качестве параметра принимает массив
		{
			innerArray = series;
			//length = series.Length;
		}


		public T this[int index] //индексатор
		{
			get
			{
				return innerArray[index];
			}

			set
			{
				innerArray[index] = value;
			}
		}

		/*	public int Length //количество заполненых элементов
			{
				get
				{
					return length;
				}
			}*/

		public int Length //количество заполненых элементов
		{
			get
			{
				int notNullElements = 0;
				for (int i = 0; i < innerArray.Length; i++)
				{
					if (innerArray[i].Equals(default(T)) == false)
					{
						notNullElements++;
					}
				}
				return notNullElements;
			}
		}

		public int Capacity //здесь пдтягиваем длину массива, которую запомнили, когда его создавали
		{
			get
			{
				int temp = innerArray.Length;
				return temp;
			}
		}

		public void Add(T element) //добавляем элемент в конец
		{
			if (Length == Capacity) //сначала проверяем, что места хватит
			{
				int capacity = Capacity * 2;
				Array.Resize(ref innerArray, capacity);
			}
			innerArray[Length + 1] = element;
			//length++;
		}

		public void AddRange(T[] elements) //добавляем массив в конец текущего массива
		{
			if ((Capacity - Length) < elements.Length) //проверяем, что место есть
			{
				int capacity = Capacity + elements.Length;
				Array.Resize(ref innerArray, capacity);
			}
			int addStart = Length;
			for (int i = 0; i < elements.Length; i++) //циклом перемещаем элементы по одному
			{
				innerArray[addStart + i] = elements[i];
			}
			//length = length + elements.Length;
		}

		public void PrintArray()
		{
			for (int i=0; i< Length; i++)
			{
				Console.WriteLine(innerArray[i]);
			}
		}

		public bool Remove(int ind) //удаляем элемент с заданным индексом
		{
			if ((ind >= 0) && (ind < Length)) //проверяем что такой индекс в массиве есть
			{
				for (int i = ind; i < Length - 1; i++) //сдвигаем элементы массива влево, начиная с освобождаемой ячейки
				{
					innerArray[i] = innerArray[i + 1];
				}
				innerArray[Length - 1] = default(T); //очищаем последнюю, которая освободилась
				//length--;
				return true;
			}
			else
			{
				return false;
			}
		}

		public void Insert(int ind, T element) //добавляем элемент на указанную позицию
		{
			if (Length == Capacity) //проверяем, что есть место
			{
				int capacity = Capacity * 2;
				Array.Resize(ref innerArray, capacity);
			}
			try
			{
				int curElement = Length;
				for (int i = curElement + 1; i > ind; i--) //сдвигаем элементы масива вправо
				{
					innerArray[i] = innerArray[i - 1];
				}
				innerArray[ind] = element; //требуемую позицию перезаписываем нужным элементом
				//length++;
			}
			catch (IndexOutOfRangeException ex) //выводим ошибку
			{
				Console.WriteLine(ex.Message);
			}
		}
	}


		class Prorram
		{
			static void Main()
			{
			/*int[] arr = new int[] { 1, 2 };
			DynamicArray<int> darr = new DynamicArray<int>(arr);
			int n = darr.Length;

			DynamicArray<int> darr1 = new DynamicArray<int>();

			int c = darr1.Capacity;

		int[] arr1 = new int[3];
		var d = arr1[0];
	//	var e = arr1[9];
		arr1[2] = 4;
		//arr1[10] = 6;

		int?[] arr2 = new int?[3];
		int f = arr2.Length;

		int j = 0;
		for (int i=0; i< arr2.Length; i++)
		{
			if (arr2[i] != null)
				j++;
		}*/

			DynamicArray<int> dinar = new DynamicArray<int>(3);

			Console.WriteLine();
			Console.WriteLine(dinar.Length);
			Console.WriteLine(dinar.Capacity);

			dinar.Add(6);

			Console.WriteLine();
			Console.WriteLine(dinar.Length);
			Console.WriteLine(dinar.Capacity);

			int[] arr = new int[] { 1, 2, 3, 4, 5 };

			dinar.AddRange(arr);

			Console.WriteLine();
			Console.WriteLine(dinar.Length);
			Console.WriteLine(dinar.Capacity);

			Console.WriteLine();
			dinar.PrintArray();

			dinar.Remove(4);

			Console.WriteLine();
			Console.WriteLine(dinar.Length);
			Console.WriteLine(dinar.Capacity);

			Console.ReadKey();

			}
		}
}
