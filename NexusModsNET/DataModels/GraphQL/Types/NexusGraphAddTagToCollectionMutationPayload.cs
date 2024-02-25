using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphAddTagToCollectionMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}