using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphFilterComparisonOperator
	{
		[EnumMember(Value = "EQUALS")]
		Equals,
		[EnumMember(Value = "NOT_EQUALS")]
		NotEquals,
		[EnumMember(Value = "MATCHES")]
		Matches,
		[EnumMember(Value = "WILDCARD")]
		Wildcard,
		[EnumMember(Value = "GT")]
		Gt,
		[EnumMember(Value = "GTE")]
		Gte,
		[EnumMember(Value = "LT")]
		Lt,
		[EnumMember(Value = "LTE")]
		Lte,
	}
}