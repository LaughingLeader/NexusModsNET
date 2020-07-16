﻿using Newtonsoft.Json;
using NexusModsNET.Internals.Converters;

namespace NexusModsNET.DataModels
{
	public class NexusGameCategory
	{
		[JsonProperty("category_id")]
		public long CategoryId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("parent_category")]
		[JsonConverter(typeof(NullableLongConverter))]
		public long? ParentCategory { get; set; }
	}
}
