using System;
using GitLabApiClient.Models.Groups.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Projects.Responses;

public class PipelineSchedule
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("ref")]
    public string Ref { get; set; }

    [JsonProperty("cron")]
    public string Cron { get; set; }

    [JsonProperty("cron_timezone")]
    public string CronTimezone { get; set; }

    [JsonProperty("next_run_at")]
    public DateTimeOffset NextRunAt { get; set; }

    [JsonProperty("active")]
    public bool Active { get; set; }

    [JsonProperty("created_at")]
    public DateTimeOffset CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTimeOffset UpdatedAt { get; set; }

    [JsonProperty("owner")]
    public Owner Owner { get; set; }
}
