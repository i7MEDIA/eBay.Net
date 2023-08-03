using EbayNet.InventoryAPIs.Models.Enums;

namespace EbayNet.InventoryAPIs.Models
{
	public class Dimension
	{
		public LengthUnitOfMeasure Unit { get; set; }
		public decimal Height { get; set; }
		public decimal Length { get; set; }
		public decimal Width { get; set; }
	}
}
