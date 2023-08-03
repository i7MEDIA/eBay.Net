using System;

namespace EbayNet
{
	public sealed class EbayException : Exception
	{
		public EbayException()
		{ }

		public EbayException(string message) : base(message)
		{ }

		public EbayException(string message, Exception innerException) : base(message, innerException)
		{ }
	}
}
