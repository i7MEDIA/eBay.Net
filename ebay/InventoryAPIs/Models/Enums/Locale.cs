using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EbayNet.InventoryAPIs.Models.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Locale
	{
		en_US,
		en_CA,
		fr_CA,
		en_GB,
		en_AU,
		en_IN,
		de_AT,
		fr_BE,
		fr_FR,
		de_DE,
		it_IT,
		nl_BE,
		nl_NL,
		es_ES,
		de_CH,
		fi_FI,
		zh_HK,
		hu_HU,
		en_PH,
		pl_PL,
		pt_PT,
		ru_RU,
		en_SG,
		en_IE,
		en_MY
	}
}
