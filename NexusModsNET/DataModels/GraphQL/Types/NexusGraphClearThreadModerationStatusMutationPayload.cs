using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphClearThreadModerationStatusMutationPayload
	{
		[JsonProperty("commentThread")]
		public NexusGraphCommentThread CommentThread { get; set; }
	}
}