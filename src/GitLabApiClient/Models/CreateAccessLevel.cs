using Newtonsoft.Json;

namespace GitLabApiClient.Models;

public class CreateAccessLevel
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("access_level")]
    public long AccessLevel { get; set; }

    [JsonProperty("access_level_description")]
    public string AccessLevelDescription { get; set; }

    [JsonProperty("deploy_key_id")]
    public object DeployKeyId { get; set; }

    [JsonProperty("user_id")]
    public long? UserId { get; set; }

    [JsonProperty("group_id")]
    public object GroupId { get; set; }
}
