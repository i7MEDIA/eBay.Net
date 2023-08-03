namespace BrowseAPIs.Models
{
	using Newtonsoft.Json;
	using System;

	public partial class ItemSummaryCollectionModel
	{
		[JsonProperty("href")]
		public Uri Href { get; set; }

		[JsonProperty("total")]
		public long Total { get; set; }

		[JsonProperty("next")]
		public Uri Next { get; set; }

		[JsonProperty("limit")]
		public long Limit { get; set; }

		[JsonProperty("offset")]
		public long Offset { get; set; }

		[JsonProperty("itemSummaries")]
		public ItemSummaryModel[] ItemSummaries { get; set; }
	}


	public partial class ItemSummaryCollectionModel
	{
		public static ItemSummaryCollectionModel FromJson(string json)
		{
			return JsonConvert.DeserializeObject<ItemSummaryCollectionModel>(json, Converter.Settings);
		}
	}
}
