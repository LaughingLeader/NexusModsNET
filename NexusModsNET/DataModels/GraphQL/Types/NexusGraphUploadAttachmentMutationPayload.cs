using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUploadAttachmentMutationPayload
	{
		[JsonProperty("attachment")]
		public NexusGraphAttachment Attachment { get; set; }
	}
}