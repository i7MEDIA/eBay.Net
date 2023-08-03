using System.Threading.Tasks;
using EbayNet.Authentication;
using Flurl;
using Flurl.Http;

namespace EbayNet
{
	public sealed class EbayRestClient
	{
		public IOAuth2Authenticator Authenticator { get; set; }
		public UrlService UrlService { get; set; } = new UrlService();


		public async Task<T> GetAsync<T>(IFlurlRequest flurlRequest)
		{
			var token = await Authenticator.GetTokenAsync();

			flurlRequest.Url = Url.Combine(UrlService.Url, flurlRequest.Url);

			try
			{
				return await flurlRequest
					.WithOAuthBearerToken(token.AccessToken)
					.GetAsync()
					.ReceiveJson<T>()
					.ConfigureAwait(false);
			}
			catch (FlurlHttpException ex)
			{
				throw new EbayException(ex.Message, ex);
			}
		}


		public async Task<T> PostAsync<T>(IFlurlRequest flurlRequest, object requestBody)
		{
			var token = await Authenticator.GetTokenAsync();

			flurlRequest.Url = Url.Combine(UrlService.Url, flurlRequest.Url);

			try
			{
				return await flurlRequest
					.WithOAuthBearerToken(token.AccessToken)
					.PostJsonAsync(requestBody)
					.ReceiveJson<T>()
					.ConfigureAwait(false);
			}
			catch (FlurlHttpException ex)
			{
				throw new EbayException(ex.Message, ex);
			}
		}


		public async Task DeleteAsync(IFlurlRequest flurlRequest)
		{
			var token = await Authenticator.GetTokenAsync();

			flurlRequest.Url = Url.Combine(UrlService.Url, flurlRequest.Url);

			try
			{
				await flurlRequest
					.WithOAuthBearerToken(token.AccessToken)
					.DeleteAsync()
					.ConfigureAwait(false);
			}
			catch (FlurlHttpException ex)
			{
				throw new EbayException(ex.Message, ex);
			}

		}
	}
}
