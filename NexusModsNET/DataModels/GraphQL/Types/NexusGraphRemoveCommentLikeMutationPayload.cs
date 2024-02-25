using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRemoveCommentLikeMutationPayload
	{
		[JsonProperty("comment")]
		public NexusGraphComment Comment { get; set; }
	}
}