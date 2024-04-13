namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphCreateCollectionCommentPayload
{
	[JsonPropertyName("collectionComment")]
	public NexusGraphComment CollectionComment { get; set; }
}