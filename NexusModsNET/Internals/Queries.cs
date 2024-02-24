using System;
using System.Collections.Generic;
using System.Text;

namespace NexusModsNET.Internals
{
	public static class Queries
	{
		/// <summary>
		/// Query for getting collection data for a specific revision
		/// </summary>
		public static readonly string CollectionRevision = @"query collectionRevision($slug: String, $adult: Boolean, $domain: String, $revision: Int) { collectionRevision(slug: $slug, viewAdultContent: $adult, domainName: $domain, revision: $revision) { collection { id slug name summary category { name } adultContent overallRating overallRatingCount endorsements totalDownloads draftRevisionNumber latestPublishedRevision { fileSize modCount } game { id domainName name } user { memberId avatar name } tileImage { url altText thumbnailUrl(size: small) } } revisionNumber collectionChangelog { createdAt description id } createdAt updatedAt downloadLink fileSize gameVersions { id reference } rating { average total } metadata { ratingValue } status modFiles { file { mod { author category modCategory { id name } name pictureUrl status summary uploader { name avatar memberId } version } modId fileId size name version description uri game { domainName } owner { name avatar memberId } } } }";
	}
}
