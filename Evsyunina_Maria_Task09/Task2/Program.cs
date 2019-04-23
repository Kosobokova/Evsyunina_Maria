/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class DynamicArray<T>
	{
		private T[] innerArray; //собственно массив


		public DynamicArray() //Конструктор без параметров (создается массив емкостью 8 элементов)

		{
			innerArray = new T[8];
		}

		public DynamicArray(int elementsCount) //Конструктор с 1 целочисленным параметром (создается массив заданной емкости)
		{
			innerArray = new T[elementsCount];
		}

		public DynamicArray(T[] series) //Конструктор, который в качестве параметра принимает массив
		{
			innerArray = series;
		}

		public DynamicArray(IEnumerable<T> inumer) //Конструктор, который в качестве параметра принимает массив
		{

			while (inumer.MoveNext())   // пока не будет возвращено false
			{
				innerArray.Add(inumer.Current);     // берем элемент на текущей позиции
				Console.WriteLine(item);
			}


			innerArray = series;
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
		}

		public void PrintArray()
		{
			for (int i = 0; i < Length; i++)
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
}
