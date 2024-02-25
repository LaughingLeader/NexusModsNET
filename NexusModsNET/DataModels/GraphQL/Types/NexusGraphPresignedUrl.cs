using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphPresignedUrl
	{
		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("uuid")]
		public string Uuid { get; set; }
	}
}