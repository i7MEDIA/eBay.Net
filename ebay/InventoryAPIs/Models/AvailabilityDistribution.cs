namespace EbayNet.InventoryAPIs.Models
{
	public class AvailabilityDistribution
	{
		public TimeDuration FulfillmentTime { get; set; }
		public string MerchantLocationKey { get; set; }
		public int Quantity { get; set; }
	}
}
