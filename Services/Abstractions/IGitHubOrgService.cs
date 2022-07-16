using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Services.Abstractions
{
    public interface IGitHubOrgService
    {
        Task<GitHubOrg> GetOrgInfo(string OrgName);
    }
}
