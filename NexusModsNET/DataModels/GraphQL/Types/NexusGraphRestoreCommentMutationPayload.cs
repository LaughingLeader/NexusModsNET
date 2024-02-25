using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphRestoreCommentMutationPayload
	{
		[JsonProperty("comment")]
		public NexusGraphComment Comment { get; set; }
	}
}