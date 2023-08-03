namespace EbayNet.InventoryAPIs.Models
{
	public class PackageWeightAndSize
	{
		public Dimension Dimensions { get; set; }
		public string PackageType { get; set; }
		public Weight Weight { get; set; }
	}
}
