namespace EbayNet
{
	public sealed class UrlService
	{
		private const string productionUrl = "https://api.ebay.com/";
		private const string sandboxUrl = "https://api.sandbox.ebay.com/";

		private const string sellBasePath = "sell/inventory/v1/";
		private const string browseBasePath = "buy/browse/v1/";

		public string SellBasePath => sellBasePath;
		public string BrowseBasePath => browseBasePath;

		public string Url => Environment == Environment.Production ? productionUrl : sandboxUrl;
		public Environment Environment { get; set; }


		public UrlService(Environment environment = Environment.Production)
		{
			Environment = environment;
		}
	}
}
