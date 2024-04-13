namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphModUpload
{
	[JsonPropertyName("claimed")]
	public bool Claimed { get; set; }

	[JsonPropertyName("contentPreviewGenerated")]
	public bool ContentPreviewGenerated { get; set; }

	[JsonPropertyName("createdAt")]
	public string CreatedAt { get; set; }

	[JsonPropertyName("discardedAt")]
	public string DiscardedAt { get; set; }

	[JsonPropertyName("fileChunksReassembled")]
	public bool FileChunksReassembled { get; set; }

	[JsonPropertyName("fileId")]
	public int FileId { get; set; }

	[JsonPropertyName("game")]
	public NexusGraphGame? Game { get; set; }

	[JsonPropertyName("id")]
	public string Id { get; set; }

	[JsonPropertyName("internalVirusScanStatus")]
	public int InternalVirusScanStatus { get; set; }

	[JsonPropertyName("md5")]
	public string Md5 { get; set; }

	[JsonPropertyName("modFile")]
	public NexusGraphModFile? ModFile { get; set; }

	[JsonPropertyName("modId")]
	public int ModId { get; set; }

	[JsonPropertyName("s3UploadComplete")]
	public bool S3uploadComplete { get; set; }

	[JsonPropertyName("s3Url")]
	public string S3url { get; set; }

	[JsonPropertyName("sha256")]
	public string Sha256 { get; set; }

	[JsonPropertyName("sizeBytes")]
	public string SizeBytes { get; set; }

	[JsonPropertyName("systemFileName")]
	public string SystemFileName { get; set; }

	[JsonPropertyName("tempFileName")]
	public string TempFileName { get; set; }

	[JsonPropertyName("updatedAt")]
	public string UpdatedAt { get; set; }

	[JsonPropertyName("uploadType")]
	public string UploadType { get; set; }

	[JsonPropertyName("user")]
	public NexusGraphUser? User { get; set; }

	[JsonPropertyName("virusTotalPositives")]
	public int VirusTotalPositives { get; set; }

	[JsonPropertyName("virusTotalStatus")]
	public int VirusTotalStatus { get; set; }

	[JsonPropertyName("virusTotalUrl")]
	public string VirusTotalUrl { get; set; }
}