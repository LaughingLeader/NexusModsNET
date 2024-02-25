using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCommentSearchResultEdge
	{
		[JsonProperty("cursor")]
		public string Cursor { get; set; }

		[JsonProperty("node")]
		public NexusGraphComment? Node { get; set; }

		[JsonProperty("relevance")]
		public float Relevance { get; set; }
	}
}