using System;
using Newtonsoft.Json;

namespace SampleApp.Models
{
	public class GitHubUser
    {
        [JsonProperty("name")]
        public string DisplayName { get; set; }
        [JsonProperty("avatar_url")]
        public string Avatar { get; set; }
        [JsonProperty("location")]
		public string Country { get; set; }
		public string Bio { get; set; }
	}
}

