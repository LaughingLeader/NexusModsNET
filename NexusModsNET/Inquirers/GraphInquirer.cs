using Newtonsoft.Json;

using NexusModsNET.DataModels.GraphQL.Query;
using NexusModsNET.Internals;

using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NexusModsNET.Inquirers
{
	/// <summary>
	/// Routes specific to retrieve graphql data
	/// </summary>
	public class GraphInquirer : InquirerBase, IGraphInquirer
	{
		/// <summary>
		/// Routes specific to retrieve graphql data
		/// </summary>
		/// <param name="client">The NexusMods client to use for this endpoint</param>
		public GraphInquirer(INexusModsClient client) : base(client) { }

		/// <summary>
		/// Query CollectionRevision data for a given game/collection/revision.
		/// </summary>
		/// <param name="gameDomain">The game id</param>
		/// <param name="slug">The collection id</param>
		/// <param name="revision">The collection revision</param>
		/// <param name="allowAdultContent">Whether to include mods with adult content</param>
		/// <returns></returns>
		public Task<NexusGraphQueryCollectionRevisionResult> GetCollectionRevisionAsync(string gameDomain, string slug, long revision, bool allowAdultContent, CancellationToken cancellationToken = default)
		{
			var requestUri = ConstructRequestUri(Routes.V2.GraphQL);

			var data = new NexusGraphQueryCollectionRevisionRequestData(gameDomain, slug, revision, allowAdultContent);
			var payload = JsonConvert.SerializeObject(data);
			var content = new StringContent(payload, Encoding.UTF8, "application/json");

			return Client.ProcessRequestAsync<NexusGraphQueryCollectionRevisionResult>(requestUri, HttpMethod.Post, cancellationToken, content);
		}

		/// <summary>
		/// Send a payload to the GraphQL API.
		/// </summary>
		/// <param name="jsonData">The payload to send to the GraphQL API. Should contain information such as the query, variables, and api key.</param>
		/// <returns></returns>
		public Task<T> PostAsync<T>(StringContent jsonData, CancellationToken cancellationToken = default)
		{
			var requestUri = ConstructRequestUri(Routes.V2.GraphQL);
			return Client.ProcessRequestAsync<T>(requestUri, HttpMethod.Post, cancellationToken, jsonData);
		}
	}
}
