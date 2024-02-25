using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUntrackUserMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}