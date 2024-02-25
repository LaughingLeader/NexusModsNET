using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionSchema
	{
		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }
	}
}