using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace EbayNet.InventoryAPIs.Models.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Condition
	{
		NEW,
		LIKE_NEW,
		NEW_OTHER,
		NEW_WITH_DEFECTS,
		MANUFACTURER_REFURBISHED,
		CERTIFIED_REFURBISHED,
		EXCELLENT_REFURBISHED,
		VERY_GOOD_REFURBISHED,
		GOOD_REFURBISHED,
		SELLER_REFURBISHED,
		USED_EXCELLENT,
		USED_VERY_GOOD,
		USED_GOOD,
		USED_ACCEPTABLE,
		FOR_PARTS_OR_NOT_WORKING
	}
}
