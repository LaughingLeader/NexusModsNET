using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRemoveKudosMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}