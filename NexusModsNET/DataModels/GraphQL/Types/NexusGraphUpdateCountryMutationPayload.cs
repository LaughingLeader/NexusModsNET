using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUpdateCountryMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}