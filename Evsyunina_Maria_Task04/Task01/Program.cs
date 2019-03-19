using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
	class User
	{
		private string UserName;
		private string UserPatronymic;
		private string UserLastName;
		DateTime UserBirthDate;

		public User(string userName, string userPatronymic, string userLastName, DateTime userBirthDate)
		{
			UserName = userName;
			UserPatronymic = userPatronymic;
			UserLastName = userLastName;
			UserBirthDate = userBirthDate;
		}

		public void UserInfo()
		{
			var now = DateTime.Today;
			int userAge = now.Year - UserBirthDate.Year - 1 +
				((now.Month > UserBirthDate.Month || now.Month == UserBirthDate.Month && now.Day >= UserBirthDate.Day) ? 1 : 0);

			Console.WriteLine($"Имя {UserName}, Отчество {UserPatronymic}, Фамилия {UserLastName}, Дата рождения {UserBirthDate}, Возраст {userAge}");
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите имя пользователя");

			string name1 = Console.ReadLine();

			Console.WriteLine("Введите отчетство пользователя");

			string patronymic1 = Console.ReadLine();

			Console.WriteLine("Введите фамилию пользователя");

			string lastName1 = Console.ReadLine();

			Console.WriteLine("Введите дату рождения пользователя");

			DateTime birthDate1 = DateTime.Parse(Console.ReadLine());

			User FirstUser = new User(name1, patronymic1, lastName1, birthDate1);

			FirstUser.UserInfo();

			Console.ReadKey();
		}
	}
}
