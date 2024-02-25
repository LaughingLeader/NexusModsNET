using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateTagMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }

		[JsonProperty("tag")]
		public NexusGraphTag? Tag { get; set; }
	}
}