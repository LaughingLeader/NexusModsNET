using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModEndorserEdge
	{
		[JsonProperty("cursor")]
		public string Cursor { get; set; }

		[JsonProperty("endorsedAt")]
		public DateTimeOffset EndorsedAt { get; set; }

		[JsonProperty("node")]
		public NexusGraphUser? Node { get; set; }
	}
}