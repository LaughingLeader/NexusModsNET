using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphAddTileImageToCollectionMutationPayload
	{
		[JsonProperty("image")]
		public NexusGraphCollectionImage Image { get; set; }
	}
}