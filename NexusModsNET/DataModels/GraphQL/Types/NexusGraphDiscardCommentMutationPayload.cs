using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphDiscardCommentMutationPayload
	{
		[JsonProperty("comment")]
		public NexusGraphComment Comment { get; set; }
	}
}