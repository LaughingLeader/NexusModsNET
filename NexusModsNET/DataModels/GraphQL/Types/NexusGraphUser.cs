namespace NexusModsNET.DataModels.GraphQL.Types;

public class NexusGraphUser
{
	[JsonPropertyName("about")]
	public string About { get; set; }

	[JsonPropertyName("avatar")]
	public string Avatar { get; set; }

	[JsonPropertyName("banned")]
	public bool Banned { get; set; }

	[JsonPropertyName("country")]
	public string Country { get; set; }

	[JsonPropertyName("deleted")]
	public bool Deleted { get; set; }

	[JsonPropertyName("donationsEnabled")]
	public bool DonationsEnabled { get; set; }

	[JsonPropertyName("dpOptedIn")]
	public bool DpOptedIn { get; set; }

	[JsonPropertyName("email")]
	public string Email { get; set; }

	[JsonPropertyName("endorsementsGiven")]
	public int EndorsementsGiven { get; set; }

	[JsonPropertyName("hasGivenKudos")]
	public bool HasGivenKudos { get; set; }

	[JsonPropertyName("ipAddress")]
	public string IpAddress { get; set; }

	[JsonPropertyName("isBlocked")]
	public bool IsBlocked { get; set; }

	[JsonPropertyName("isTracked")]
	public bool IsTracked { get; set; }

	[JsonPropertyName("joined")]
	public DateTimeOffset Joined { get; set; }

	[JsonPropertyName("kudos")]
	public int Kudos { get; set; }

	[JsonPropertyName("lastActive")]
	public DateTimeOffset LastActive { get; set; }

	[JsonPropertyName("memberId")]
	public int MemberId { get; set; }

	[JsonPropertyName("membershipRoles")]
	public string[] MembershipRoles { get; set; }

	[JsonPropertyName("name")]
	public string Name { get; set; }

	[JsonPropertyName("paypal")]
	public string Paypal { get; set; }

	[JsonPropertyName("posts")]
	public int Posts { get; set; }

	[JsonPropertyName("recognizedAuthor")]
	public bool RecognizedAuthor { get; set; }

	[JsonPropertyName("uniqueModDownloads")]
	public int UniqueModDownloads { get; set; }

	[JsonPropertyName("views")]
	public int Views { get; set; }
}