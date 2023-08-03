using System.Collections.Generic;

namespace EbayNet.InventoryAPIs.Models
{
	public class Availability
	{
		public List<PickupAtLocationAvailability> PickupAtLocationAvailability { get; set; }
		public ShipToLocationAvailability ShipToLocationAvailability { get; set; }
	}
}
