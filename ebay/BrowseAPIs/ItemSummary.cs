using BrowseAPIs.Models;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

/*
	https://developer.ebay.com/api-docs/buy/browse/resources/methods
	Lets shoppers search for specific items by keyword, GTIN, category, product,
	or item aspects and refine the results by using filters.
*/
namespace EbayNet.BrowseAPIs
{
	public sealed class ItemSummary
	{
		private string itemSummaryUrl = "buy/browse/v1/item_summary/search";
		private readonly EbayRestClient ebayRestClient;

		public ItemSummary(EbayRestClient ebayRestClient)
		{
			this.ebayRestClient = ebayRestClient;
		}

		public async Task<ItemSummaryCollectionModel> Search(string search, int limit = 50)
		{
			var item = await ebayRestClient.GetAsync<ItemSummaryCollectionModel>(
				itemSummaryUrl
					.AppendPathSegment($"?q={search}&limit={limit}", fullyEncode: true)
					.WithHeaders(
						new
						{
							Content_Type = "application/json",
							X_EBAY_C_ENDUSERCTX = "contextualLocation=country=<2_character_country_code>,zip=<zip_code>,affiliateCampaignId=<ePNCampaignId>,affiliateReferenceId=<referenceId>"
						}, replaceUnderscoreWithHyphen: true)
					)
					.ConfigureAwait(false);

			return item;
		}
	}
}
