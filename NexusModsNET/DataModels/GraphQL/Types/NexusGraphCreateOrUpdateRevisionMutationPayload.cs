using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateOrUpdateRevisionMutationPayload
	{
		[JsonProperty("collection")]
		public NexusGraphCollection Collection { get; set; }

		[JsonProperty("collectionId")]
		public int CollectionId { get; set; }

		[JsonProperty("revision")]
		public NexusGraphCollectionRevision Revision { get; set; }

		[JsonProperty("revisionId")]
		public int RevisionId { get; set; }

		[JsonProperty("revisionNumber")]
		public int RevisionNumber { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}