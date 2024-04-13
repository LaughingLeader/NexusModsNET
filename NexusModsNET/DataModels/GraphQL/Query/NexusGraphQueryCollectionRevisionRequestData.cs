

using NexusModsNET.Internals;namespace NexusModsNET.DataModels.GraphQL.Query;

public class NexusGraphQueryCollectionRevisionRequestData
{
	[JsonPropertyName("domain")]
	public GraphArgument Domain => new("String", false);

	[JsonPropertyName("slug")]
	public GraphArgument Slug => new("String", false);

	[JsonPropertyName("revision")]
	public GraphArgument Revision => new("Int", false);

	[JsonPropertyName("viewAdultContent")]
	public GraphArgument ViewAdultContent => new("Boolean", true);

	[JsonPropertyName("variables")]
	public NexusGraphQueryCollectionRevisionRequestVariables Variables { get; set; }

	[JsonPropertyName("query")]
	public string Query { get; }

	public NexusGraphQueryCollectionRevisionRequestData(string gameDomain, string slug, long revision, bool allowAdultContent, string query = null)
	{
		Query ??= Queries.CollectionRevision;
		Variables = new()
		{
			Domain = gameDomain,
			Slug = slug,
			Revision = revision,
			ViewAdultContent = allowAdultContent
		};
	}
}
