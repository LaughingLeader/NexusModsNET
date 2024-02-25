using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphOptedInMod
	{
		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("game")]
		public NexusGraphGame? Game { get; set; }

		[JsonProperty("gameId")]
		public int GameId { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("mod")]
		public NexusGraphMod? Mod { get; set; }

		[JsonProperty("modId")]
		public int ModId { get; set; }

		[JsonProperty("ratio")]
		public float Ratio { get; set; }

		[JsonProperty("uploader")]
		public NexusGraphUser? Uploader { get; set; }

		[JsonProperty("uploaderId")]
		public int UploaderId { get; set; }
	}
}