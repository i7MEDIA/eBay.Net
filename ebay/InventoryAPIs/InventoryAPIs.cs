namespace EbayNet.InventoryAPIs
{
	public class InventoryAPIs
	{
		public int Item { get; set; }
		public int ItemGroup { get; set; }
		public int Listing { get; set; }
		public int Offer { get; set; }
		public int Location { get; set; }

		public InventoryAPIs(EbayRestClient restClient)
		{

		}
	}
}
