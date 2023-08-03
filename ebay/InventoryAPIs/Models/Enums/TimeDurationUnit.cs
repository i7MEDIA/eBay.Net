using Newtonsoft.Json.Converters;
using Newtonsoft.Json;

namespace EbayNet.InventoryAPIs.Models.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum TimeDurationUnit
	{
		YEAR,
		MONTH,
		DAY,
		HOUR,
		CALENDAR_DAY,
		BUSINESS_DAY,
		MINUTE,
		SECOND,
		MILLISECOND
	}
}
