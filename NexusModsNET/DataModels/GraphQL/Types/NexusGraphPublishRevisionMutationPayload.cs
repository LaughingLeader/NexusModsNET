using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphPublishRevisionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}