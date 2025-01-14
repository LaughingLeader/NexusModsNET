﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using NexusModsNET.DataModels;
using NexusModsNET.Internals;
using NexusModsNET.Internals.Handlers;

namespace NexusModsNET
{
	/// <summary>
	/// A HttpClient for the nexusmods.com API.
	/// </summary>
	public class NexusModsClient : INexusModsClient
	{
		#region Fields
		/// <summary>
		/// The underlying HttpClient
		/// </summary>
		private HttpClient _httpClient;
		private readonly RateLimitsManagement _rateLimitsManagement;
		#endregion

		#region Properties
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public string APIKey { get; }
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public string ProductName { get; }
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public string ProductVersion { get; }
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public string UserAgent { get; }
		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public IRateLimitsManagement RateLimitsManagement { get => _rateLimitsManagement; }
		#endregion

		#region Constructors
		private NexusModsClient(string apiKey, string productName, string productVersion, INexusApiLimits rateLimits = null)
		{
			// Initialize properties
			APIKey = apiKey;
			ProductName = productName;
			ProductVersion = productVersion;
			_rateLimitsManagement = new RateLimitsManagement(rateLimits);
			UserAgent = ConstructUserAgent(ProductName, ProductVersion);
			InitializeHttpClient();
		}
		private NexusModsClient(string apiKey, INexusApiLimits rateLimits = null) : this(apiKey, Assembly.GetExecutingAssembly().GetName().Name, Assembly.GetExecutingAssembly().GetName().Version.ToString(3), rateLimits) { }
		#endregion

		#region Factory Methods
		/// <summary>
		/// Creates a new client for the NexusMods API, which requires at least a API key to be provided.
		/// </summary>
		/// <param name="apiKey">A key specific to NexusMods.com account, which must be provided to allow usage of the API</param>
		/// <returns></returns>
		public static INexusModsClient Create(string apiKey, INexusApiLimits rateLimits = null)
		{
			ThrowIfNull(apiKey, nameof(apiKey));
			return new NexusModsClient(apiKey);
		}

		/// <summary>
		/// Creates a new client for the NexusMods API, which requires at least a API key to be provided.
		/// </summary>
		/// <param name="apiKey">A key specific to NexusMods.com account, which must be provided to allow usage of the API</param>
		/// <param name="productName">A product name to send with each request, this is used to construct a UserAgent string</param>
		/// <param name="productVersion">A product version to send with each request, this is used to construct a UserAgent string</param>
		/// <returns></returns>
		public static INexusModsClient Create(string apiKey, string productName, string productVersion, INexusApiLimits rateLimits = null)
		{
			ThrowIfNull(apiKey, nameof(apiKey));
			ThrowIfNull(productName, nameof(productName));
			ThrowIfNull(productVersion, nameof(productVersion));
			return new NexusModsClient(apiKey, productName, productVersion, rateLimits);
		}
		#endregion

		#region Methods
		/// <summary>
		/// Sends Http requests and deserializes the response content to the specified .NET type
		/// </summary>
		/// <typeparam name="T">The .NET type to deserialize the Json</typeparam>
		/// <param name="requestUri">The full request URL</param>
		/// <param name="method">The type of the Http request</param>
		/// <param name="cancellationToken">Enables cancellation of the Http request</param>
		/// <param name="formData">The encoded form data to send with the Http request to the API server</param>
		/// <returns>The deserialized JSON response content as the specified .NET type</returns>
		public async Task<T> ProcessRequestAsync<T>(Uri requestUri, HttpMethod method, CancellationToken cancellationToken = default, HttpContent formData = null)
		{
			T output = default;
			var httpRequestMessage = ConstructHttpRequestMessage(requestUri, method, formData);

			using (var response = await _httpClient.SendAsync(httpRequestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
			{
				if (response.IsSuccessStatusCode)
				{
					output = await response.Content.DeserializeContent<T>();
				}
			}

			return output;
		}

		/// <summary>
		/// Sends Http requests and deserializes the response content to the specified .NET type
		/// </summary>
		/// <typeparam name="T">The .NET type to deserialize the Json</typeparam>
		/// <param name="requestMessage">The http request message to send</param>
		/// <param name="cancellationToken">Enables cancellation of the Http request</param>
		/// <returns>The deserialized JSON response content as the specified .NET type</returns>
		public async Task<T> ProcessRequestAsync<T>(HttpRequestMessage requestMessage, CancellationToken cancellationToken = default)
		{
			T output = default;

			using (var response = await _httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead, cancellationToken))
			{
				if (response.IsSuccessStatusCode)
				{
					output = await response.Content.DeserializeContent<T>();
				}
			}

			return output;
		}

		/// <summary>
		/// Creates a new HttpRequestMessage
		/// </summary>
		/// <param name="method">The type of the request</param>
		/// <param name="requestUri">The request URL</param>
		/// <param name="httpContent">The Http request message content (form, etc.)</param>
		/// <param name="acceptedMediaType">The accepted response message format, default is application/json</param>
		/// <returns></returns>
		public HttpRequestMessage ConstructHttpRequestMessage(Uri requestUri, HttpMethod method, HttpContent httpContent = null, string acceptedMediaType = null)
		{
			var httpRequestMessage = new HttpRequestMessage
			{
				RequestUri = requestUri,
				Method = method
			};

			if (httpContent != null)
			{
				httpRequestMessage.Content = httpContent;
			}

			if (!string.IsNullOrWhiteSpace(acceptedMediaType))
			{
				httpRequestMessage.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptedMediaType));
			}

			return httpRequestMessage;
		}

		/// <summary>
		/// <inheritdoc/>
		/// </summary>
		public void Dispose()
		{
			((IDisposable)_httpClient).Dispose();
		}
		#endregion

		#region Helpers
		private void InitializeHttpClient()
		{
			// Initialize the HttpClient handlers
			var httpClientHandler = new HttpClientHandler() { AllowAutoRedirect = true };
			var quotaLimitsProcessor = new ApiLimitsHandler(httpClientHandler, UpdateLimits, RateLimitsManagement);
			var nexusErrorsHandler = new NexusErrorsHandler(quotaLimitsProcessor);

			// Initialize the HttpClient
			_httpClient = new HttpClient(nexusErrorsHandler);

			// Configure the HttpClient
			_httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			_httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(ConstructUserAgent(ProductName, ProductVersion));
			_httpClient.DefaultRequestHeaders.Add("apikey", APIKey);
		}
		private string ConstructUserAgent(string productName, string productVersion)
		{
			return $"{productName}/{productVersion} ({RuntimeInformation.OSDescription}; {RuntimeInformation.OSArchitecture})";
		}
		private string GetHeaderValue(HttpResponseMessage httpResponse, string header)
		{
			string value = "";
			if (httpResponse.Headers.TryGetValues(header, out IEnumerable<string> values))
			{
				value = values.FirstOrDefault();
			}
			return value;
		}
		private bool TryUpdateLimits(HttpResponseMessage httpResponse)
		{
			try
			{
				int hLimit = int.Parse(GetHeaderValue(httpResponse, "X-RL-Hourly-Limit"));
				int hRemaining = int.Parse(GetHeaderValue(httpResponse, "X-RL-Hourly-Remaining"));
				int dLimit = int.Parse(GetHeaderValue(httpResponse, "X-RL-Daily-Limit"));
				int dRemaining = int.Parse(GetHeaderValue(httpResponse, "X-RL-Daily-Remaining"));
				DateTime hReset = DateTime.Parse(GetHeaderValue(httpResponse, "X-RL-Hourly-Reset"));
				DateTime dReset = DateTime.Parse(GetHeaderValue(httpResponse, "X-RL-Daily-Reset"));
				_rateLimitsManagement.APILimits.DailyLimit = dLimit;
				_rateLimitsManagement.APILimits.DailyRemaining = dRemaining;
				_rateLimitsManagement.APILimits.DailyReset = dReset;
				_rateLimitsManagement.APILimits.HourlyLimit = hLimit;
				_rateLimitsManagement.APILimits.HourlyRemaining = hRemaining;
				_rateLimitsManagement.APILimits.HourlyReset = hReset;

				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		private void UpdateLimits(HttpResponseMessage httpResponse)
		{
			TryUpdateLimits(httpResponse);
		}
		private static void ThrowIfNull(string value, string propertyName)
		{
			if (string.IsNullOrWhiteSpace(value)) { throw new ArgumentNullException($"Parameter {propertyName} can't be null or empty !"); }
		}
		#endregion
	}
}
