using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphDiscardRevisionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}