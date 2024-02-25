using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphHideCommentMutationPayload
	{
		[JsonProperty("comment")]
		public NexusGraphComment Comment { get; set; }
	}
}