using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

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
