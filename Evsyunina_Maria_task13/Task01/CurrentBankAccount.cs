using System;
using ClassExceptions;

namespace BankAccountSimulation
{
	public class CurrentBankAccount : BankAccount
	{
		public CurrentBankAccount(string accountOwnerName, string accountNumber)
			: base(accountOwnerName, accountNumber)
		{
			this.MinAccountBalance = 0m;
			this.MaxDepositAmount = 100000000m;
			InteresetRate = .25m;
		}

		public override void Deposit(decimal amount)
		{
			try
			{
				if (amount <= 0)
				{
					throw new IncorrectSumException(string.Format("Сумма операции не может быть отрицательной!"));
				}
				if (amount >= MaxDepositAmount)
				{
					throw new MaxAmountExceedException(string.Format("Превышена максимальная сумма депозита! Максимальная сумма депозита {0}", MaxDepositAmount.ToString()));
				}
				AccountBalance = AccountBalance + amount;
				TransactionSummary = string.Format("{0}\n Deposit:{1}", TransactionSummary, amount);
			}
			catch (IncorrectSumException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (MaxAmountExceedException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}



		public override void Withdraw(decimal amount)
		{
			try
			{
				if (amount <= 0)
				{
					throw new IncorrectSumException(string.Format("Сумма операции не может быть отрицательной!"));
				}
				if (AccountBalance - amount <= MinAccountBalance)
				{
					throw new WithdrawLimitException(string.Format("Остаток денежных средств на счете не может быть ниже {0}!", MinAccountBalance.ToString())); ;
				}

				AccountBalance = AccountBalance - amount;
				TransactionSummary = string.Format("{0}\n Withdraw:{1}", TransactionSummary, amount);
			}
			catch (IncorrectSumException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch (WithdrawLimitException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}

		public override void GenerateAccountReport()
		{
			Console.WriteLine("Current Account Report");
			base.GenerateAccountReport();
		}
	}
}