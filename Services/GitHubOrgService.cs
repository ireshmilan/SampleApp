using SampleApp.Models;
using SampleApp.RestServices;
using SampleApp.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services
{
    public class GitHubOrgService : IGitHubOrgService
    {
        private IGitHubApiService _gitHubApiService;

        public async Task<GitHubOrg> GetOrgInfo(string OrgName)
        {
            return await _gitHubApiService.GetOrgName(OrgName);
        }
        public GitHubOrgService(IGitHubApiService gitHubApiService)
        {
            _gitHubApiService = gitHubApiService;
        }
    }
}
