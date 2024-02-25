using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphCommentThreadModerationStatus
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "locked")]
		Locked,
	}
}