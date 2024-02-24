using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphLatestPublishedRevision
	{
		[JsonProperty("fileSize")]
		public string FileSize { get; set; }

		[JsonProperty("modCount")]
		public int ModCount { get; set; }
	}
}