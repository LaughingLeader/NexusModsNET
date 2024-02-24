using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Text;

namespace NexusModsNET.DataModels.GraphQL.Query
{
	public class NexusGraphQueryCollectionRevisionRequestVariables
	{
		[JsonProperty("domain")]
		public string Domain { get; set; }

		[JsonProperty("slug")]
		public string Slug { get; set; }

		[JsonProperty("revision")]
		public string Revision { get; set; }

		[JsonProperty("viewAdultContent")]
		public bool ViewAdultContent { get; set; }
	}
}
