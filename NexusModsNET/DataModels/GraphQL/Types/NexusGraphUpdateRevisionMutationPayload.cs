using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUpdateRevisionMutationPayload
	{
		[JsonProperty("revisionId")]
		public int RevisionId { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}