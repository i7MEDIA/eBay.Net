using EbayNet.InventoryAPIs.Models.Enums;

namespace EbayNet.InventoryAPIs.Models
{
	public class PickupAtLocationAvailability
	{
		public AvailabilityType AvailabilityType { get; set; }
		public TimeDuration FulfillmentTime { get; set; }
		public string MerchantLocationKey { get; set; }
		public int Quantity { get; set; }
	}
}
