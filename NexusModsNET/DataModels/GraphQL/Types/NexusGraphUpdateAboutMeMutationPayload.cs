using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUpdateAboutMeMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}