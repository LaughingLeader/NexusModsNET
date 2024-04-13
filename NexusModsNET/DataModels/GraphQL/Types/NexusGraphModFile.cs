namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModFile : INexusGraphNode
{
	[JsonPropertyName("categoryId")]
	public int CategoryId { get; set; }

	[JsonPropertyName("count")]
	public int Count { get; set; }

	[JsonPropertyName("date")]
	public int Date { get; set; }

	[JsonPropertyName("description")]
	public string Description { get; set; }

	[JsonPropertyName("fileId")]
	public int FileId { get; set; }

	[JsonPropertyName("game")]
	public NexusGraphGame Game { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("manager")]
	public int Manager { get; set; }

	[JsonPropertyName("mod")]
	public NexusGraphMod Mod { get; set; }

	[JsonPropertyName("modId")]
	public int ModId { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("owner")]
	public NexusGraphUser Owner { get; set; }

	[JsonPropertyName("primary")]
	public int Primary { get; set; }

	[JsonPropertyName("reportLink")]
	public string ReportLink { get; set; }

	[JsonPropertyName("requirementsAlert")]
	public int RequirementsAlert { get; set; }

	[JsonPropertyName("scanned")]
	public int Scanned { get; set; }

	[JsonPropertyName("size")]
	public int Size { get; set; }

	[JsonPropertyName("sizeInBytes")]
	public long SizeInBytes { get; set; }

	[JsonPropertyName("uCount")]
	public int Ucount { get; set; }

	[JsonPropertyName("uid")]
	public string Uid { get; set; }

	[JsonPropertyName("uri")]
	public string Uri { get; set; }

	[JsonPropertyName("version")]
	public string Version { get; set; }
}