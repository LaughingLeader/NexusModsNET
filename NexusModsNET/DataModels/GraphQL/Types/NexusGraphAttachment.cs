namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphAttachment : INexusGraphNode
{
	[JsonPropertyName("filename")]
	public string Filename { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("url")]
	public string Url { get; set; }
}