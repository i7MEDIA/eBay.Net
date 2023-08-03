using System.Collections.Generic;

namespace EbayNet.InventoryAPIs.Models
{
	public class Product
	{
		public string Aspects { get; set; }
		public string Brand { get; set; }
		public string Description { get; set; }
		public List<string> EAN { get; set; }
		public string EPID { get; set; }
		public List<string> ImageUrls { get; set; }
		public List<string> ISBN { get; set; }
		public string MPN { get; set; }
		public string Subtitle { get; set; }
		public string Title { get; set; }
		public List<string> UPC { get; set; }
		public List<string> VideoIds { get; set; }
	}
}
