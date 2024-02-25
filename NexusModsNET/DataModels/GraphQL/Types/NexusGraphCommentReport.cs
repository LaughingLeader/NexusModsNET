using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCommentReport
	{
		[JsonProperty("comment")]
		public NexusGraphComment Comment { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("reason")]
		public string Reason { get; set; }

		[JsonProperty("reporter")]
		public NexusGraphUser Reporter { get; set; }

		[JsonProperty("status")]
		public NexusGraphCommentReportStatus Status { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }
	}
}