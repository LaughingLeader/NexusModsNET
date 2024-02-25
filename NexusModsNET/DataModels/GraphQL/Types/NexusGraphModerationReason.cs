using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModerationReason
	{
		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("reason")]
		public string Reason { get; set; }

		[JsonProperty("resolution")]
		public string Resolution { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}