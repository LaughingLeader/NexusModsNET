using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphFilterLogicalOperator
	{
		[EnumMember(Value = "AND")]
		And,
		[EnumMember(Value = "OR")]
		Or,
	}
}