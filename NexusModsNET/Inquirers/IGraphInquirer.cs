using NexusModsNET.DataModels.GraphQL.Query;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace NexusModsNET.Inquirers
{
	/// <summary>
	/// Routes specific to retrieve information regarding supported games
	/// </summary>
	public interface IGraphInquirer : IDisposable
	{
		/// <summary>
		/// Returns an <see cref="IEnumerable{T}"/> of all games, optionally can also return unapproved games
		/// </summary>
		/// <param name="gameDomain">The game id</param>
		/// <param name="slug">The collection id</param>
		/// <param name="revision">The collection revision</param>
		/// <param name="allowAdultContent">Whether to include mods with adult content</param>
		/// <returns></returns>
		Task<NexusGraphQueryCollectionRevisionResult> GetCollectionRevisionAsync(string gameDomain, string slug, long revision, bool allowAdultContent, CancellationToken cancellationToken = default);
	}
}
