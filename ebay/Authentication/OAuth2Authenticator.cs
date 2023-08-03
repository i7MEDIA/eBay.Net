using EbayNet.Extensions;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

namespace EbayNet.Authentication
{
	public sealed class OAuth2Authenticator : IOAuth2Authenticator
	{
		private const string tokenRequestEndpoint = "identity/v1/oauth2/token/";
		private const string scopeEndpoint = "oauth/api_scope";
		private Token token = new Token();

		public string Base64EncodedCredentials { get; }
		public UrlService UrlService { get; set; } = new UrlService();


		public OAuth2Authenticator(string clientId, string clientSecret)
		{
			Base64EncodedCredentials = $"{clientId}:{clientSecret}".Base64Encode();
		}


		/// <summary>
		/// Format specification: https://developer.ebay.com/api-docs/static/oauth-base64-credentials.html
		/// </summary>
		/// <param name="base64EncodedOAuthCredentials"> Base64 encoded "clientId:clientSecret" </param>
		public OAuth2Authenticator(string base64EncodedOAuthCredentials)
		{
			Base64EncodedCredentials = base64EncodedOAuthCredentials;
		}


		public async Task<Token> GetTokenAsync()
		{
			if (token.HasExpired)
			{
				token = await AuthenticateAsync().ConfigureAwait(false);
			}

			return token;
		}

		internal async Task<Token> AuthenticateAsync()
		{
			var url = UrlService.Url;

			try
			{
				var result = await url
					.AppendPathSegment(tokenRequestEndpoint)
					.WithHeaders(
						new
						{
							Content_Type = "application/x-www-form-urlencoded",
							Authorization = $"Basic {Base64EncodedCredentials}"
						},
						replaceUnderscoreWithHyphen: true)
					.PostUrlEncodedAsync(
						new
						{
							grant_type = "client_credentials",
							scope = url.AppendPathSegment(scopeEndpoint).Path
						})
					.ReceiveJson<Token>()
					.ConfigureAwait(false);

				return result;
			}
			catch (FlurlHttpException ex)
			{
				throw new EbayException(ex.Message, ex);
			}
		}
	}
}
