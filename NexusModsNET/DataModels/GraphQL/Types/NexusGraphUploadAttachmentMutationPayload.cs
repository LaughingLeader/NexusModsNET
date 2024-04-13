namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUploadAttachmentMutationPayload
{
	[JsonPropertyName("attachment")]
	public NexusGraphAttachment Attachment { get; set; }
}