using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphAttachment : INexusGraphNode
	{
		[JsonProperty("filename")]
		public string Filename { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }
	}
}