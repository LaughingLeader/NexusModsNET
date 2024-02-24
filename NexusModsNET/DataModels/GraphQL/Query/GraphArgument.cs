using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Query
{
	public class GraphArgument
	{
		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("optional")]
		public bool Optional { get; set; }

		public GraphArgument(string typeName, bool optional = false)
		{
			Type = typeName;
			Optional = optional;
		}
	}
}
