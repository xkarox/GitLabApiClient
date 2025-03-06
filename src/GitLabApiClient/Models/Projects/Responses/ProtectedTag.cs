using Newtonsoft.Json;

namespace GitLabApiClient.Models.Projects.Responses;

public class ProtectedTag
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("create_access_levels")]
    public CreateAccessLevel[] CreateAccessLevels { get; set; }
}
