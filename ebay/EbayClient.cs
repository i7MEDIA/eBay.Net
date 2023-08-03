using EbayNet.Authentication;
using EbayNet.BrowseAPIs;

namespace EbayNet
{
	public sealed class EbayClient
	{
		private IOAuth2Authenticator authenticator;
		private EbayRestClient restClient;

		public Environment Environment { get; private set; }
		public BrowseAPI Browse { get; private set; }


		/// <summary>
		/// EbayClient will take care and encode your clientID and clientSecret
		/// </summary>
		/// <param name="clientId">App ID (Client ID)</param>
		/// <param name="clientSecret">Cert ID (Client Secret)</param>
		public EbayClient(string clientId, string clientSecret, Environment environment = Environment.Production)
		{
			Setup(new OAuth2Authenticator(clientId, clientSecret), environment);
		}


		/// <summary>
		/// Format specification: https://developer.ebay.com/api-docs/static/oauth-base64-credentials.html
		/// </summary>
		/// <param name="base64EncodedOAuthCredentials"> Base64 encoded "clientId:clientSecret" </param>
		public EbayClient(string base64EncodedOAuthCredentials, Environment environment = Environment.Production)
		{
			Setup(new OAuth2Authenticator(base64EncodedOAuthCredentials), environment);
		}


		public EbayClient(IOAuth2Authenticator authenticator, Environment environment = Environment.Production)
		{
			Setup(authenticator, environment);
		}


		private void Setup(IOAuth2Authenticator authenticator, Environment environment)
		{
			this.authenticator = authenticator;
			this.Environment = environment;

			InitializeAPIs();
		}


		private void InitializeAPIs()
		{
			var urlService = new UrlService(Environment);

			authenticator.UrlService = urlService;

			restClient = new EbayRestClient
			{
				Authenticator = authenticator,
				UrlService = urlService
			};

			Browse = new BrowseAPI(restClient);
		}
	}
}
