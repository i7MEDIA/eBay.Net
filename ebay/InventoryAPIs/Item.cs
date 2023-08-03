namespace EbayNet.InventoryAPIs
{
	public sealed class Item
	{
		/// <summary>
		/// Gets all items or performs CRUD operations on a single item when passing a SKU "/{sku}".
		/// Create, Get (Read), Replace (Update), Delete
		/// </summary>
		private const string singleItem = "inventory_item";
		private const string bulkOrCreateOrReplace = "bulk_create_or_replace_inventory_item";
		private const string bulkGet = "bulk_get_inventory_item";
		private const string bulkUpdatePriceQuantity = "bulk_update_price_quantity";

		private readonly EbayRestClient restClient;


		public Item(EbayRestClient restClient)
		{
			this.restClient = restClient;
		}
	}
}
