using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateEndorsementMutationPayload
	{
		[JsonProperty("endorsement")]
		public NexusGraphEndorsement Endorsement { get; set; }

		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}