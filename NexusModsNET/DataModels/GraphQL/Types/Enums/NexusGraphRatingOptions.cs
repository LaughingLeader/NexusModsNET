using System.Runtime.Serialization;namespace NexusModsNET.DataModels.GraphQL.Types;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum NexusGraphRatingOptions
{
	[EnumMember(Value = "positive")]
	Positive,
	[EnumMember(Value = "negative")]
	Negative,
	[EnumMember(Value = "abstained")]
	Abstained,
}