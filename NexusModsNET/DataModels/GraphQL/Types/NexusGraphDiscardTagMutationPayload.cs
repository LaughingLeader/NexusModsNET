using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphDiscardTagMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}