using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphReorderPinnedCommentsMutationPayload
	{
		[JsonProperty("comments")]
		public NexusGraphComment[] Comments { get; set; }
	}
}