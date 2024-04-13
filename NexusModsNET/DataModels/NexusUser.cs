﻿namespace NexusModsNET.DataModels;

public class NexusUser
{
	[JsonPropertyName("user_id")]
	public long UserId { get; set; }

	[JsonPropertyName("key")]
	public string Key { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("email")]
	public string Email { get; set; }

	[JsonPropertyName("profile_url")]
	public Uri ProfileAvatarUrl { get; set; }

	[JsonPropertyName("is_supporter")]
	public bool IsSupporter { get; set; }

	[JsonPropertyName("is_premium")]
	public bool IsPremium { get; set; }
}
