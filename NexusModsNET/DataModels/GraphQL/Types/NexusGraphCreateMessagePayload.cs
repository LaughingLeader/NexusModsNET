using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateMessagePayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}