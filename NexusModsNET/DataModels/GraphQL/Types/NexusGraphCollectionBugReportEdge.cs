using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionBugReportEdge
	{
		[JsonProperty("cursor")]
		public string Cursor { get; set; }

		[JsonProperty("node")]
		public NexusGraphCollectionBugReport? Node { get; set; }
	}
}