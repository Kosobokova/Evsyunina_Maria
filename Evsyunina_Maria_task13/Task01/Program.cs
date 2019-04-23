using System;
using ClassExceptions;

namespace BankAccountSimulation
{
	public class Program
	{
		static void Main(string[] args)
		{
			BankAccount savingAccount = new SavingBankAccount("Sarvesh", "S12345");
			BankAccount currentAccount = new CurrentBankAccount("Mark", "C12345");

			BankAccount savingAccountTest = new SavingBankAccount("Vanya", "S12347");
			BankAccount currentAccounttest = new CurrentBankAccount("Vasya", "C12345");


			savingAccount.Deposit(40000);
			savingAccount.Withdraw(1000);
			savingAccount.Withdraw(1000);
			savingAccount.Withdraw(1000);

			// Generate Report
			savingAccount.GenerateAccountReport();

			Console.WriteLine();
			currentAccount.Deposit(190000);
			currentAccount.Withdraw(1000);
			currentAccount.GenerateAccountReport();

			//тестируем исключения
			savingAccountTest.Deposit(-100);
			savingAccountTest.Deposit(1000);
			savingAccountTest.Withdraw(-1000);
			savingAccountTest.Withdraw(2000);

			savingAccountTest.GenerateAccountReport();

			Console.ReadLine();
		}
	}
}
