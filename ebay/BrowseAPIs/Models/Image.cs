using Newtonsoft.Json;
using System;

namespace BrowseAPIs.Models
{
	public partial class Image
	{
		[JsonProperty("imageUrl")]
		public Uri ImageUrl { get; set; }
	}
}
