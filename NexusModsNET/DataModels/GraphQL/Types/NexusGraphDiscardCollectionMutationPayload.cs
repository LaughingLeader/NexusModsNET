using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphDiscardCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}