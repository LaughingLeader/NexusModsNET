﻿using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL
{
	public class NexusGraphCollectionRevisionQueryResult
	{
		[JsonProperty("collectionRevision")]
		public NexusGraphCollectionRevision CollectionRevision { get; set; }

		[JsonProperty("collection")]
		public NexusGraphCollection Collection { get; set; }

		[JsonProperty("collectionChangelog")]
		public NexusGraphChangelog CollectionChangelog { get; set; }
	}
}
