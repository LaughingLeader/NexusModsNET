using Newtonsoft.Json;

using NexusModsNET.DataModels.GraphQL.Types;

namespace NexusModsNET.DataModels.GraphQL.Query
{
	public class NexusGraphQueryCollectionRevisionData
	{
		[JsonProperty("collectionRevision")]
		public NexusGraphCollectionRevision CollectionRevision { get; set; }
	}

	public class NexusGraphQueryCollectionRevisionResult
	{
		[JsonProperty("data")]
		public NexusGraphQueryCollectionRevisionData Data { get; set; }
	}
}
