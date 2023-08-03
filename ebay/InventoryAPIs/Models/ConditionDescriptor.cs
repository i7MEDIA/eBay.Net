using System.Collections.Generic;

namespace EbayNet.InventoryAPIs.Models
{
	public class ConditionDescriptor
	{
		public string AdditionalInfo { get; set; }
		public string Name { get; set; }
		public List<string> Values { get; set; }
	}
}
