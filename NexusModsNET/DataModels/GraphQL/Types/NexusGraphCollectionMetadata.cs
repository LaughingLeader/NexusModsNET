using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphCollectionMetadata
	{
		[JsonProperty("downloadedAt")]
		public DateTimeOffset DownloadedAt { get; set; }

		[JsonProperty("endorsementValue")]
		public int EndorsementValue { get; set; }

		[JsonProperty("latestDownloadedRevisionNumber")]
		public int LatestDownloadedRevisionNumber { get; set; }
	}
}