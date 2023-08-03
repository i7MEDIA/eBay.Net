using System.Collections.Generic;

namespace EbayNet.InventoryAPIs.Models
{

	public class ShipToLocationAvailability
	{
		public List<AvailabilityDistribution> AvailabilityDistributions { get; set; }
		public int Quantity { get; set; }
	}
}
