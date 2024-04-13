namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphPresignedUrl
{
	[JsonPropertyName("url")]
	public string Url { get; set; }

	[JsonPropertyName("uuid")]
	public string Uuid { get; set; }
}