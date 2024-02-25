using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphModUpload
	{
		[JsonProperty("claimed")]
		public bool Claimed { get; set; }

		[JsonProperty("contentPreviewGenerated")]
		public bool ContentPreviewGenerated { get; set; }

		[JsonProperty("createdAt")]
		public string CreatedAt { get; set; }

		[JsonProperty("discardedAt")]
		public string DiscardedAt { get; set; }

		[JsonProperty("fileChunksReassembled")]
		public bool FileChunksReassembled { get; set; }

		[JsonProperty("fileId")]
		public int FileId { get; set; }

		[JsonProperty("game")]
		public NexusGraphGame? Game { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("internalVirusScanStatus")]
		public int InternalVirusScanStatus { get; set; }

		[JsonProperty("md5")]
		public string Md5 { get; set; }

		[JsonProperty("modFile")]
		public NexusGraphModFile? ModFile { get; set; }

		[JsonProperty("modId")]
		public int ModId { get; set; }

		[JsonProperty("s3UploadComplete")]
		public bool S3uploadComplete { get; set; }

		[JsonProperty("s3Url")]
		public string S3url { get; set; }

		[JsonProperty("sha256")]
		public string Sha256 { get; set; }

		[JsonProperty("sizeBytes")]
		public string SizeBytes { get; set; }

		[JsonProperty("systemFileName")]
		public string SystemFileName { get; set; }

		[JsonProperty("tempFileName")]
		public string TempFileName { get; set; }

		[JsonProperty("updatedAt")]
		public string UpdatedAt { get; set; }

		[JsonProperty("uploadType")]
		public string UploadType { get; set; }

		[JsonProperty("user")]
		public NexusGraphUser? User { get; set; }

		[JsonProperty("virusTotalPositives")]
		public int VirusTotalPositives { get; set; }

		[JsonProperty("virusTotalStatus")]
		public int VirusTotalStatus { get; set; }

		[JsonProperty("virusTotalUrl")]
		public string VirusTotalUrl { get; set; }
	}
}