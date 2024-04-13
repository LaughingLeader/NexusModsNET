

using NexusModsNET.DataModels.GraphQL.Types;namespace NexusModsNET.DataModels.GraphQL.Query;

public class NexusGraphQueryCollectionRevisionData
{
	[JsonPropertyName("collectionRevision")]
	public NexusGraphCollectionRevision CollectionRevision { get; set; }
}

public class NexusGraphQueryCollectionRevisionResult
{
	[JsonPropertyName("data")]
	public NexusGraphQueryCollectionRevisionData Data { get; set; }
}
