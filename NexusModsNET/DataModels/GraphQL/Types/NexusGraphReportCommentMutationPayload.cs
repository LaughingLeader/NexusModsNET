using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphReportCommentMutationPayload
	{
		[JsonProperty("report")]
		public NexusGraphCommentReport Report { get; set; }
	}
}