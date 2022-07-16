using System;
using RestEase;
using SampleApp.Models;

namespace SampleApp.RestServices
{
    [Header("User-Agent", "RestEase")]
    public interface IGitHubApiService
	{
        [Get("/users/{userName}")]
        Task<GitHubUser> GetUserInfo([Path] string userName);

        [Get("/orgs/{orgName}")]
        Task<GitHubOrg> GetOrgName([Path] string orgName);
    }
}

