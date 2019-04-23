using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ClassMain
    {
        static void Main(string[] args)
        {
            Person vanya = new Person("Vanya");
            Person petya = new Person("Petya");
            Person borya = new Person("Borya");

            vanya.ComeToOffice += petya.OfficeMessage(Show_Message);
            petya.ComeToOffice += new Person.OfficeMessage(Show_Message);
            borya.ComeToOffice += new Person.OfficeMessage(Show_Message);

            vanya.LeaveOffice += new Person.OfficeMessage(Show_Message);
            petya.LeaveOffice += new Person.OfficeMessage(Show_Message);
            borya.LeaveOffice += new Person.OfficeMessage(Show_Message);

            vanya.Greet(petya, DateTime.Now);
            petya.Greet(petya, DateTime.Now);
            borya.Greet(petya, DateTime.Now);
            


            Console.ReadKey();
        }
        private static void Show_Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
