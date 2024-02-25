using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphActionLogEdge
	{
		[JsonProperty("cursor")]
		public string Cursor { get; set; }

		[JsonProperty("node")]
		public NexusGraphActionLog? Node { get; set; }
	}
}