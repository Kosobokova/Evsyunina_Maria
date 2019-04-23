using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Person
    {
        public delegate void OfficeMessage(string message);

        public event OfficeMessage ComeToOffice;

        public event OfficeMessage LeaveOffice;

        string name { get; set; }

        public void Greet(Person a, DateTime time)
        {
            if (time.Hour < 12)
            {
                ComeToOffice($"Доброе утро, {a.name}!");
            }
            if ((time.Hour > 12)&& (time.Hour < 17))
            {
                ComeToOffice($"Добрый день, {a.name}!");
            }
            if (time.Hour > 17)
            {
                ComeToOffice($"Добрый вечер, {a.name}!");
            }
        }

        public void Farewell(Person a)
        {
            LeaveOffice($"До свидания, {a.name}!");
        }

        public Person(string name)
        {
            this.name = name;
        }
    }
}
