using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EbayNet.InventoryAPIs.Models.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AvailabilityType
	{
		IN_STOCK,
		OUT_OF_STOCK,
		SHIP_TO_STORE
	}
}
