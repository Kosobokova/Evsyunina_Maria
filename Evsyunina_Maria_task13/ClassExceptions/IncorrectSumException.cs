using System;

namespace ClassExceptions
{
	public class IncorrectSumException : Exception
	{
		public IncorrectSumException()
		{
		}

		public IncorrectSumException(string message)
			: base(message)
		{
		}

		public IncorrectSumException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}

	public class MaxAmountExceedException : Exception
	{
		public MaxAmountExceedException()
		{
		}

		public MaxAmountExceedException(string message)
			: base(message)
		{
		}

		public MaxAmountExceedException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}


	public class WithdrawCountEsceedException : Exception
	{
		public WithdrawCountEsceedException()
		{
		}

		public WithdrawCountEsceedException(string message)
			: base(message)
		{
		}

		public WithdrawCountEsceedException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}

	public class WithdrawLimitException : Exception
	{
		public WithdrawLimitException()
		{
		}

		public WithdrawLimitException(string message)
			: base(message)
		{
		}

		public WithdrawLimitException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}

	public class ReportException : Exception
	{
		public ReportException()
		{
		}

		public ReportException(string message)
			: base(message)
		{
		}

		public ReportException(string message, Exception inner)
			: base(message, inner)
		{
		}
	}
}
