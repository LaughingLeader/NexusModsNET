using Newtonsoft.Json;

using NexusModsNET.Internals;

namespace NexusModsNET.DataModels.GraphQL.Query
{
	public class NexusGraphQueryCollectionRevisionRequestData
	{
		[JsonProperty("domain")]
		public GraphArgument Domain => new GraphArgument("String", false);

		[JsonProperty("slug")]
		public GraphArgument Slug => new GraphArgument("String", false);

		[JsonProperty("revision")]
		public GraphArgument Revision => new GraphArgument("Int", false);

		[JsonProperty("viewAdultContent")]
		public GraphArgument ViewAdultContent => new GraphArgument("Boolean", true);

		[JsonProperty("variables")]
		public NexusGraphQueryCollectionRevisionRequestVariables Variables { get; set; }

		[JsonProperty("query")]
		public string Query => Queries.CollectionRevision;

		public NexusGraphQueryCollectionRevisionRequestData(string gameDomain, string slug, long revision, bool allowAdultContent)
		{
			Variables = new()
			{
				Domain = gameDomain,
				Slug = slug,
				Revision = revision,
				ViewAdultContent = allowAdultContent
			};
		}
	}
}
