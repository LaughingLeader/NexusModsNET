﻿using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphCollectionRevision
	{
		[JsonProperty("id")]
		public long Id { get; set; }

		[JsonProperty("createdAt")]
		public string CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}
