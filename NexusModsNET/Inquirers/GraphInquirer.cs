using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

using NexusModsNET.DataModels;
using NexusModsNET.DataModels.GraphQL;
using NexusModsNET.Internals;

using GraphQL.Query.Builder;
using GraphQL.Query.Builder.Formatter.NewtonsoftJson;
using NexusModsNET.DataModels.GraphQL.Query;
using Newtonsoft.Json;
using System.Text;

namespace NexusModsNET.Inquirers
{
	/// <summary>
	/// Routes specific to retrieve graphql data
	/// </summary>
	public class GraphInquirer : InquirerBase
	{
		/// <summary>
		/// Routes specific to retrieve graphql data
		/// </summary>
		/// <param name="client">The NexusMods client to use for this endpoint</param>
		public GraphInquirer(INexusModsClient client) : base(client) { }

		//$slug: String, $adult: Boolean, $domain: String, $revision: Int

		/// <summary>
		/// Returns an <see cref="IEnumerable{T}"/> of all games, optionally can also return unapproved games
		/// </summary>
		/// <param name="gameDomain">The game id</param>
		/// <param name="slug">The collection id</param>
		/// <param name="revision">The collection revision</param>
		/// <param name="allowAdultContent">Whether to include mods with adult content</param>
		/// <returns></returns>
		public Task<NexusGraphCollectionRevisionQueryResult> GetCollectionRevisionAsync(string gameDomain, string slug, int revision, bool allowAdultContent, CancellationToken cancellationToken = default)
		{
			var requestUri = ConstructRequestUri(Routes.V2.GraphQL);

			var data = new NexusGraphQueryCollectionRevisionRequestData(gameDomain, slug, revision, allowAdultContent);
			var payload = JsonConvert.SerializeObject(data);
			var content = new StringContent(payload, Encoding.UTF8, "application/json");

			return Client.ProcessRequestAsync<NexusGraphCollectionRevisionQueryResult>(requestUri, HttpMethod.Post, cancellationToken, content);
		}
	}
}
