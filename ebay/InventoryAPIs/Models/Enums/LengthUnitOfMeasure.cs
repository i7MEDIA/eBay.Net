using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EbayNet.InventoryAPIs.Models.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LengthUnitOfMeasure
	{
		INCH,
		FEET,
		CENTIMETER,
		METER
	}
}
