using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModFile : INexusGraphNode
	{
		[JsonProperty("categoryId")]
		public int CategoryId { get; set; }

		[JsonProperty("count")]
		public int Count { get; set; }

		[JsonProperty("date")]
		public int Date { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("fileId")]
		public int FileId { get; set; }

		[JsonProperty("game")]
		public NexusGraphGame Game { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("manager")]
		public int Manager { get; set; }

		[JsonProperty("mod")]
		public NexusGraphMod Mod { get; set; }

		[JsonProperty("modId")]
		public int ModId { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("owner")]
		public NexusGraphUser Owner { get; set; }

		[JsonProperty("primary")]
		public int Primary { get; set; }

		[JsonProperty("reportLink")]
		public string ReportLink { get; set; }

		[JsonProperty("requirementsAlert")]
		public int RequirementsAlert { get; set; }

		[JsonProperty("scanned")]
		public int Scanned { get; set; }

		[JsonProperty("size")]
		public int Size { get; set; }

		[JsonProperty("sizeInBytes")]
		public long SizeInBytes { get; set; }

		[JsonProperty("uCount")]
		public int Ucount { get; set; }

		[JsonProperty("uid")]
		public string Uid { get; set; }

		[JsonProperty("uri")]
		public string Uri { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }
	}
}