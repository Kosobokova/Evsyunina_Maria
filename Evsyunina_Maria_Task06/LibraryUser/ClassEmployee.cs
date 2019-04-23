using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task1
{
	public class Employee : User
	{
		private string Position; // должность
		private DateTime EmploymentDate; //дата трудоустройства

		public string PositionAccess //доступ к должности
		{
			get
			{
				return Position;
			}
			set
			{
				if (!Regex.IsMatch(value, @"\p{ P}\d"))
				{
					Position = value;
				}
			}
		}

		public DateTime EmploymentDateAccess // доступ к дате трудоустройства (устроился не раньше, чем родился)
		{
			get
			{
				return EmploymentDate;
			}
			set
			{
				if (UserBirthDateAccess.CompareTo(value) < 0)
				{
					EmploymentDate = value;
				}
			}
		}

		public Employee(string userName, string userPatronymic, string userLastName, DateTime userBirthDate, string position, DateTime employmentDate) : base(userName, userPatronymic, userLastName, userBirthDate)
		{
			PositionAccess = position;
			EmploymentDateAccess = employmentDate; //конструктор

		}
	}
}
