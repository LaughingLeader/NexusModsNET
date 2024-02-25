using Newtonsoft.Json;

namespace NexusModsNET.DataModels.GraphQL.Types
{
	public interface INexusGraphAttachable
	{
		[JsonProperty("attachments")]
		public NexusGraphAttachment[] Attachments { get; set; }
	}
}