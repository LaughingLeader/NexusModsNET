using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateCollectionCommentPayload
	{
		[JsonProperty("collectionComment")]
		public NexusGraphComment CollectionComment { get; set; }
	}
}