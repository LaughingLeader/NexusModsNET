using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphModerationFixStatus
	{
		[EnumMember(Value = "submitted")]
		Submitted,
		[EnumMember(Value = "accepted")]
		Accepted,
		[EnumMember(Value = "rejected")]
		Rejected,
	}
}