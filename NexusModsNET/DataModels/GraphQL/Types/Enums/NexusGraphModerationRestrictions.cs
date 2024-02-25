using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphModerationRestrictions
	{
		[EnumMember(Value = "FILE_UPLOAD")]
		FileUpload,
		[EnumMember(Value = "MOD_TOOLS")]
		ModTools,
		[EnumMember(Value = "FILE_DOWNLOAD")]
		FileDownload,
		[EnumMember(Value = "POST")]
		Post,
		[EnumMember(Value = "COMMENT_FILE")]
		CommentFile,
		[EnumMember(Value = "IMAGE_UPLOAD")]
		ImageUpload,
		[EnumMember(Value = "ENDORSE_MOD")]
		EndorseMod,
		[EnumMember(Value = "ENDORSE_MEDIA")]
		EndorseMedia,
		[EnumMember(Value = "BLOCK_PM")]
		BlockPm,
		[EnumMember(Value = "ADD_VIDEOS")]
		AddVideos,
	}
}