using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EbayNet.InventoryAPIs.Models.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum WeightUnitOfMeasure
	{
		POUND,
		KILOGRAM,
		OUNCE,
		GRAM
	}
}
