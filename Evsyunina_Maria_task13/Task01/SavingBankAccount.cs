using System;
using ClassExceptions;

namespace BankAccountSimulation
{
	public class SavingBankAccount : BankAccount
	{
		protected int withdrawCount = 0;

		public SavingBankAccount(string accountOwnerName, string accountNumber)
			: base(accountOwnerName, accountNumber)
		{
			this.MinAccountBalance = 20000m;
			this.MaxDepositAmount = 50000m;
			InteresetRate = 3.5m;
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
				if (withdrawCount > 3)
				{
					throw new WithdrawCountEsceedException("Превышено максимальное количество снятий! Максимальное количество снятий: 3");
				}

				if (AccountBalance - amount <= MinAccountBalance)
				{
					throw new WithdrawLimitException(string.Format("Остаток денежных средств на счете не может быть ниже {0}!", MinAccountBalance.ToString()));
				}

				AccountBalance = AccountBalance - amount;
				withdrawCount++;

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
			try
			{
				Console.WriteLine("Saving Account Report");
				base.GenerateAccountReport();

				if (AccountBalance < 15000)
				{
					throw new ReportException("Недостаточно средств на счете для вывода отчета!");
				}

				Console.WriteLine("Sending Email for Account {0}", AccountNumber);
			}
			catch (ReportException ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}
