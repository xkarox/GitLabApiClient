using GitLabApiClient.Models.Branches.Responses;
using GitLabApiClient.Models.Groups.Responses;
using GitLabApiClient.Models.Users.Responses;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Projects.Responses
{
    public class ApprovalRule
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("rule_type")]
        public string RuleType { get; set; }

        [JsonProperty("report_type")]
        public object ReportType { get; set; }

        [JsonProperty("eligible_approvers")]
        public User[] EligibleApprovers { get; set; }

        [JsonProperty("approvals_required")]
        public long ApprovalsRequired { get; set; }

        [JsonProperty("users")]
        public User[] Users { get; set; }

        [JsonProperty("groups")]
        public Group[] Groups { get; set; }

        [JsonProperty("contains_hidden_groups")]
        public bool ContainsHiddenGroups { get; set; }

        [JsonProperty("protected_branches")]
        public ProtectedBranch[] ProtectedBranches { get; set; }

        [JsonProperty("applies_to_all_protected_branches")]
        public bool AppliesToAllProtectedBranches { get; set; }
    }
}

