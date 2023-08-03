using System.Collections.Generic;

namespace EbayNet.InventoryAPIs.Models
{
	public class ShipToLocationAvailabilityAll
	{
		public List<AvailabilityDistribution> AvailabilityDistributions { get; set; }
		public int Quantity { get; set; }
	}
}
