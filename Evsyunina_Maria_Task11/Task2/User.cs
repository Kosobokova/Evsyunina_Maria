using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task2
{
	public class User
	{
		private string UserName; //поля класса
		private string UserPatronymic;
		private string UserLastName;
		private DateTime UserBirthDate;

		public String UserNameAccess //доступ к имени
		{
			get
			{
				return UserName;
			}
			set
			{
				if (!Regex.IsMatch(value, @"\p{ P}\d"))
				{
					UserName = value;
				}
			}
		}

		public String UserPatronymicAccess //доступ к отчеству
		{
			get
			{
				return UserPatronymic;
			}
			set
			{
				if (!Regex.IsMatch(value, @"\p{ P}\d"))
				{
					UserPatronymic = value;
				}
			}
		}

		public String UserLastNameAccess //доступ к фамилии
		{
			get
			{
				return UserLastName;
			}
			set
			{
				if (!Regex.IsMatch(value, @"\p{ P}\d"))
				{
					UserLastName = value;
				}
			}
		}

		private DateTime LowerBorder = new DateTime(1900, 01, 01); //дата рождения не может быть раньше

		public DateTime UserBirthDateAccess //доступ к дате рождения
		{
			get
			{
				return UserBirthDate;
			}
			set
			{
				if (LowerBorder.CompareTo(value) < 0)
				{
					UserBirthDate = value;
				}
			}
		}

		public User(string userName, string userPatronymic, string userLastName, DateTime userBirthDate) //конструктор
		{
			UserNameAccess = userName;
			UserPatronymicAccess = userPatronymic;
			UserLastNameAccess = userLastName;
			UserBirthDateAccess = userBirthDate;
		}

		public void UserInfo() //метод для вывода информации по юзеру на консоль
		{
			Console.WriteLine($"Имя {UserNameAccess}, Отчество {UserPatronymicAccess}, Фамилия {UserLastNameAccess}, Дата рождения {UserBirthDateAccess}, Возраст {GetAge()}");
		}

		public int GetAge() // метод расчета возраста
		{
			var now = DateTime.Today;
			return now.Year - UserBirthDate.Year - 1 +
				((now.Month > UserBirthDate.Month || now.Month == UserBirthDate.Month && now.Day >= UserBirthDate.Day) ? 1 : 0);
		}
	}
}
}
