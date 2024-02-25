using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphGiveKudosMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}