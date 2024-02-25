using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionRevisionMod
	{
		[JsonProperty("collectionRevisionId")]
		public int CollectionRevisionId { get; set; }

		[JsonProperty("file")]
		public NexusGraphModFile? File { get; set; }

		[JsonProperty("fileId")]
		public int FileId { get; set; }

		[JsonProperty("gameId")]
		public int GameId { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("optional")]
		public bool Optional { get; set; }

		[JsonProperty("updatePolicy")]
		public string UpdatePolicy { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }
	}
}