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
		public static readonly string CollectionRevision = @"query collectionRevision($slug: String, $adult: Boolean, $domain: String, $revision: Int) { collectionRevision(slug: $slug, viewAdultContent: $adult, domainName: $domain, revision: $revision) { externalResources { author collectionRevisionId fileExpression id name optional resourceType resourceUrl version } collection { id slug name summary category { name } adultContent overallRating overallRatingCount endorsements totalDownloads draftRevisionNumber latestPublishedRevision { fileSize modCount } game { id domainName name } user { memberId avatar name } tileImage { url altText thumbnailUrl(size: small) } } revisionNumber collectionChangelog { createdAt description id } assetsSizeBytes createdAt updatedAt downloadLink fileSize gameVersions { id reference } rating { average total } status modFiles { collectionRevisionId fileId gameId id optional updatePolicy version file { mod { author category modCategory { id name } name pictureUrl status summary uploader { name avatar memberId } version } modId fileId size sizeInBytes name version description uri primary game { domainName } owner { name avatar memberId } } } } }";
	}
}
