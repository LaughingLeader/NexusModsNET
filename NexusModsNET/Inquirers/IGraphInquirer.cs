using NexusModsNET.DataModels.GraphQL.Query;

using System;
using System.Collections.Generic;
using System.Net.Http;
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

		/// <summary>
		/// Send a payload to the GraphQL API.
		/// </summary>
		/// <param name="jsonData">The payload to send to the GraphQL API. Should contain information such as the query, variables, and api key.</param>
		/// <returns></returns>
		Task<T> PostAsync<T>(StringContent jsonData, CancellationToken cancellationToken = default);
	}
}
