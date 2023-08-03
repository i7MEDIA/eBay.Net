using System.Threading.Tasks;

namespace EbayNet.Authentication
{
	public interface IOAuth2Authenticator
	{
		Task<Token> GetTokenAsync();
		UrlService UrlService { get; set; }
	}
}
