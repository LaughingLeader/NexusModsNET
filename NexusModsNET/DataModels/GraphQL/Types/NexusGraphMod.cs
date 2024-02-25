using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphMod
	{
		[JsonProperty("adultContent")]
		public bool AdultContent { get; set; }

		[JsonProperty("author")]
		public string Author { get; set; }

		[JsonProperty("category")]
		public string Category { get; set; }

		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("downloads")]
		public int Downloads { get; set; }

		[JsonProperty("endorsements")]
		public int Endorsements { get; set; }

		[JsonProperty("game")]
		public NexusGraphGame Game { get; set; }

		[JsonProperty("gameId")]
		public int GameId { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("modCategory")]
		public NexusGraphModCategory ModCategory { get; set; }

		[JsonProperty("modId")]
		public int ModId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("pictureUrl")]
		public string PictureUrl { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("summary")]
		public string Summary { get; set; }

		[JsonProperty("thumbnailUrl")]
		public string ThumbnailUrl { get; set; }

		[JsonProperty("uid")]
		public string Uid { get; set; }

		[JsonProperty("updatedAt")]
		public DateTimeOffset UpdatedAt { get; set; }

		[JsonProperty("uploader")]
		public NexusGraphUser Uploader { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }
	}
}