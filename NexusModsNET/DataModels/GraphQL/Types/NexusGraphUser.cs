using Newtonsoft.Json;

using System;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public class NexusGraphUser
	{
		[JsonProperty("about")]
		public string About { get; set; }

		[JsonProperty("avatar")]
		public string Avatar { get; set; }

		[JsonProperty("banned")]
		public bool Banned { get; set; }

		[JsonProperty("country")]
		public string Country { get; set; }

		[JsonProperty("deleted")]
		public bool Deleted { get; set; }

		[JsonProperty("donationsEnabled")]
		public bool DonationsEnabled { get; set; }

		[JsonProperty("dpOptedIn")]
		public bool DpOptedIn { get; set; }

		[JsonProperty("email")]
		public string Email { get; set; }

		[JsonProperty("endorsementsGiven")]
		public int EndorsementsGiven { get; set; }

		[JsonProperty("hasGivenKudos")]
		public bool HasGivenKudos { get; set; }

		[JsonProperty("ipAddress")]
		public string IpAddress { get; set; }

		[JsonProperty("isBlocked")]
		public bool IsBlocked { get; set; }

		[JsonProperty("isTracked")]
		public bool IsTracked { get; set; }

		[JsonProperty("joined")]
		public DateTimeOffset Joined { get; set; }

		[JsonProperty("kudos")]
		public int Kudos { get; set; }

		[JsonProperty("lastActive")]
		public DateTimeOffset LastActive { get; set; }

		[JsonProperty("memberId")]
		public int MemberId { get; set; }

		[JsonProperty("membershipRoles")]
		public string[] MembershipRoles { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("paypal")]
		public string Paypal { get; set; }

		[JsonProperty("posts")]
		public int Posts { get; set; }

		[JsonProperty("recognizedAuthor")]
		public bool RecognizedAuthor { get; set; }

		[JsonProperty("uniqueModDownloads")]
		public int UniqueModDownloads { get; set; }

		[JsonProperty("views")]
		public int Views { get; set; }
	}
}