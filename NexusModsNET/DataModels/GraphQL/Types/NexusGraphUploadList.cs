using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUploadList
	{
		[JsonProperty("filteredCount")]
		public int FilteredCount { get; set; }

		[JsonProperty("totalCount")]
		public int TotalCount { get; set; }

		[JsonProperty("uploads")]
		public NexusGraphModUpload[] Uploads { get; set; }
	}
}