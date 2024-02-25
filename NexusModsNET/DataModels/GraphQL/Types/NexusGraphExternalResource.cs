using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphExternalResource
	{
		[JsonProperty("author")]
		public string Author { get; set; }

		[JsonProperty("collectionRevisionId")]
		public int CollectionRevisionId { get; set; }

		[JsonProperty("fileExpression")]
		public string FileExpression { get; set; }

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("optional")]
		public bool Optional { get; set; }

		[JsonProperty("resourceType")]
		public string ResourceType { get; set; }

		[JsonProperty("resourceUrl")]
		public string ResourceUrl { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }
	}
}