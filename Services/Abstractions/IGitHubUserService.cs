using System;
using SampleApp.Models;
namespace SampleApp.Services.Abstractions
{
	public interface IGitHubUserService
	{
		Task<GitHubUser> GetUserInfo(string userName);
	}
}

