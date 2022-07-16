using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Models
{
    public class GitHubOrg
    {
        [JsonProperty("name")]
        public string DisplayName { get; set; }
        [JsonProperty("avatar_url")]
        public string Icon { get; set; }
        public string Id { get; set; }
        public string Description { get; set; }
    }
}
