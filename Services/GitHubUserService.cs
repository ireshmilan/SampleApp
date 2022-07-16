using System;
using SampleApp.Models;
using SampleApp.RestServices;
using SampleApp.Services.Abstractions;

namespace SampleApp.Services
{
	public class GitHubUserService : IGitHubUserService
	{
        IGitHubApiService _gitHubApi;
        public GitHubUserService(IGitHubApiService gitHubApiService)
		{
            _gitHubApi = gitHubApiService;
		}

        public async Task<GitHubUser> GetUserInfo(string userName)
        {
            return await _gitHubApi.GetUserInfo(userName);
                
        }
    }
}

