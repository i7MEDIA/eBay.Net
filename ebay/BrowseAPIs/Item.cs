using BrowseAPIs.Models;
using Flurl;
using Flurl.Http;
using System.Threading.Tasks;

/*
	https://developer.ebay.com/api-docs/buy/browse/resources/methods
	Lets you retrieve the details of a specific item or all the items in an
	item group, which is an item with variations such as color and size. This
	resource also provides a bridge between the eBay legacy APIs, such as Trading
	and Finding, and the RESTful APIs, such as Browse, which use different
	formats for the item IDs. You can use the Browse API to retrieve the basic
	details of the item and the RESTful item ID using a legacy item ID.

	e.g. https://api.ebay.com/buy/browse/v1/item/v1|
*/
namespace EbayNet.BrowseAPIs
{
	public sealed class Item
	{
		private const string itemUrl = "buy/browse/v1/item";
		private const string legacyItemUrl = "buy/browse/v1/item/get_item_by_legacy_id";
		private const string itemsByItemGroupUrl = "buy/browse/v1/item/get_items_by_item_group";
		private readonly EbayRestClient restClient;

		public Item(EbayRestClient restClient)
		{
			this.restClient = restClient;
		}


		// /item/{item_id}
		public async Task<ItemModel> GetAsync(string itemId)
		{
			var item = await restClient.GetAsync<ItemModel>(
				itemUrl
					.AppendPathSegment($"v1|{itemId}|0", fullyEncode: true)
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


		// /item/get_item_by_legacy_id
		public async Task<LegacyItemModel> GetByLegacyIdAsync(string legacyItemId)
		{
			var item = await restClient.GetAsync<LegacyItemModel>(
				legacyItemUrl
					.AppendPathSegment($"?legacy_item_id={legacyItemId}", fullyEncode: true)
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


		// /item/get_items_by_item_group
		public async Task<ItemGroupModel> GetByItemGroupAsync(string itemGroupId)
		{
			var item = await restClient.GetAsync<ItemGroupModel>(
				itemsByItemGroupUrl
					.AppendPathSegment($"?item_group_id={itemGroupId}", fullyEncode: true)
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
