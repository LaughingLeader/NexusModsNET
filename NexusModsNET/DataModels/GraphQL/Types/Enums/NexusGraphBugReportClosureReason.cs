using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphBugReportClosureReason
	{
		[EnumMember(Value = "none")]
		None,
		[EnumMember(Value = "resolved")]
		Resolved,
		[EnumMember(Value = "not_a_bug")]
		NotABug,
		[EnumMember(Value = "wont_fix")]
		WontFix,
	}
}