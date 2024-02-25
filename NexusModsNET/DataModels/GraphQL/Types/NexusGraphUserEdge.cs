using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUserEdge
	{
		[JsonProperty("cursor")]
		public string Cursor { get; set; }

		[JsonProperty("node")]
		public NexusGraphUser? Node { get; set; }
	}
}