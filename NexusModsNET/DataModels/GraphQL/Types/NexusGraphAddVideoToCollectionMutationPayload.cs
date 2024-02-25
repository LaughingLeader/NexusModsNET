using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphAddVideoToCollectionMutationPayload
	{
		[JsonProperty("video")]
		public NexusGraphCollectionVideo Video { get; set; }
	}
}