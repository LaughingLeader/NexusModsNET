namespace NexusModsNET.DataModels.GraphQL.Types;

public interface INexusGraphAttachable
{
	[JsonPropertyName("attachments")]
	public NexusGraphAttachment[] Attachments { get; set; }
}