
using Newtonsoft.Json;
using System;

namespace EbayNet.Authentication
{
	public class Token
	{
		public Token()
		{
			CreateDate = DateTime.Now;
		}

		[JsonProperty("access_token")]
		public string AccessToken { get; set; }

		[JsonProperty("expires_in")]
		public double ExpiresIn { get; set; }

		[JsonProperty("token_type")]
		public string TokenType { get; set; }

		public DateTime CreateDate { get; }

		public double ExpiryThresholdSeconds { get; set; } = 10d;

		public bool HasExpired => CreateDate.Add(TimeSpan.FromSeconds(ExpiresIn - ExpiryThresholdSeconds)) <= DateTime.Now;
	}
}
