using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphCommentReportStatus
	{
		[EnumMember(Value = "open")]
		Open,
		[EnumMember(Value = "resolved")]
		Resolved,
	}
}