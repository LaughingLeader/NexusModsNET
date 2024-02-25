using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUpdateTagMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }

		[JsonProperty("tag")]
		public NexusGraphTag Tag { get; set; }
	}
}