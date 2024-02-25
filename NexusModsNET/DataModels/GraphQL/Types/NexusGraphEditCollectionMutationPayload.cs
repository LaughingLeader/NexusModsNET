using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphEditCollectionMutationPayload
	{
		[JsonProperty("collection")]
		public NexusGraphCollection Collection { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}