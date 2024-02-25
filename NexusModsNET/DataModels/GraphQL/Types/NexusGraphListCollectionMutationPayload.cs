using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphListCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}