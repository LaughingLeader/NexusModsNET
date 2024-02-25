using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using System.Runtime.Serialization;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum NexusGraphFormalOrInformalWarning
	{
		[EnumMember(Value = "INFORMAL_WARNING")]
		InformalWarning,
		[EnumMember(Value = "FORMAL_WARNING")]
		FormalWarning,
	}
}