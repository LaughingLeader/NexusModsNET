using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCreateNoteAboutUserMutationPayload
	{
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}