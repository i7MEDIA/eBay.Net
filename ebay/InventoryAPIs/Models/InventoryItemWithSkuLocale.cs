using EbayNet.InventoryAPIs.Models.Enums;
using System.Collections.Generic;

namespace EbayNet.InventoryAPIs.Models
{
	public class InventoryItemWithSkuLocale
	{
		public Availability Availability { get; set; }
		public Condition Condition { get; set; }
		public string ConditionDescription { get; set; }
		public List<ConditionDescriptor> ConditionDescriptors { get; set; }
		public Locale Locale { get; set; }
		public PackageWeightAndSize PackageWeightAndSize { get; set; }
		public Product Product { get; set; }
		public string SKU { get; set; }
	}
}
