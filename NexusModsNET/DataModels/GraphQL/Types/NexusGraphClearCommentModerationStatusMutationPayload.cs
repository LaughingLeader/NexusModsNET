using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphClearCommentModerationStatusMutationPayload
	{
		[JsonProperty("comment")]
		public NexusGraphComment Comment { get; set; }
	}
}