namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUploadList
{
	[JsonPropertyName("filteredCount")]
	public int FilteredCount { get; set; }

	[JsonPropertyName("totalCount")]
	public int TotalCount { get; set; }

	[JsonPropertyName("uploads")]
	public NexusGraphModUpload[] Uploads { get; set; }
}