using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphAddHeaderImageToCollectionMutationPayload
	{
		[JsonProperty("image")]
		public NexusGraphCollectionImage Image { get; set; }
	}
}