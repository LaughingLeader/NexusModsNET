namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateOrUpdateRevisionMutationPayload
{
	[JsonPropertyName("collection")]
	public NexusGraphCollection Collection { get; set; }

	[JsonPropertyName("collectionId")]
	public int CollectionId { get; set; }

	[JsonPropertyName("revision")]
	public NexusGraphCollectionRevision Revision { get; set; }

	[JsonPropertyName("revisionId")]
	public int RevisionId { get; set; }

	[JsonPropertyName("revisionNumber")]
	public int RevisionNumber { get; set; }

	[JsonPropertyName("success")]
	public bool Success { get; set; }
}