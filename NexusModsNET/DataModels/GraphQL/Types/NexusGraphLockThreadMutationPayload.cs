using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphLockThreadMutationPayload
	{
		[JsonProperty("commentThread")]
		public NexusGraphCommentThread CommentThread { get; set; }
	}
}