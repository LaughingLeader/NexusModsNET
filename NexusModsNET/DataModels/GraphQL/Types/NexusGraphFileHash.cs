using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphFileHash
	{
		[JsonProperty("createdAt")]
		public DateTimeOffset CreatedAt { get; set; }

		[JsonProperty("fileName")]
		public string FileName { get; set; }

		[JsonProperty("fileSize")]
		public long FileSize { get; set; }

		[JsonProperty("fileType")]
		public string FileType { get; set; }

		[JsonProperty("gameId")]
		public int GameId { get; set; }

		[JsonProperty("md5")]
		public string Md5 { get; set; }

		[JsonProperty("modFile")]
		public NexusGraphModFile? ModFile { get; set; }

		[JsonProperty("modFileId")]
		public int ModFileId { get; set; }
	}
}