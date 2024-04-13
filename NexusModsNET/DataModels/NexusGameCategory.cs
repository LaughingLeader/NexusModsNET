namespace NexusModsNET.DataModels;

public class NexusGameCategory
{
	[JsonPropertyName("category_id")]
	public long Id { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("parent_category")]
	[JsonConverter(typeof(NullableLongConverter))]
	public long? ParentCategoryId { get; set; }
}
