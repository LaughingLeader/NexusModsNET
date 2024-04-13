namespace NexusModsNET.DataModels.GraphQL.Query;

public class NexusGraphQueryCollectionRevisionRequestVariables
{
	[JsonPropertyName("domain")]
	public string Domain { get; set; }

	[JsonPropertyName("slug")]
	public string Slug { get; set; }

	[JsonPropertyName("revision")]
	public long Revision { get; set; }

	[JsonPropertyName("viewAdultContent")]
	public bool ViewAdultContent { get; set; }
}
