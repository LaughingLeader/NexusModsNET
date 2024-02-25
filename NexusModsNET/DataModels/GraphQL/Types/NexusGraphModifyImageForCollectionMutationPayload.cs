using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModifyImageForCollectionMutationPayload
	{
		[JsonProperty("image")]
		public NexusGraphCollectionImage Image { get; set; }

		[JsonProperty("updated")]
		public bool Updated { get; set; }
	}
}