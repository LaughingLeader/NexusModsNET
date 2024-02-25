using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphAddImageToCollectionMutationPayload
	{
		[JsonProperty("image")]
		public NexusGraphCollectionImage Image { get; set; }
	}
}