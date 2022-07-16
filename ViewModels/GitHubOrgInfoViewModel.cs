using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SampleApp.Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public partial class GitHubOrgInfoViewModel : ObservableObject
    {

        private IGitHubOrgService _gitHubOrgService;

        [ObservableProperty]
        private string _orgName;
       
        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _avatar;

        [ObservableProperty]
        private string _id;

        [ObservableProperty]
        private string _description;

        public GitHubOrgInfoViewModel(IGitHubOrgService gitHubOrgService)
        {
            _gitHubOrgService = gitHubOrgService;
            
        }

        [RelayCommand]
        public async void GetOrgInfo()
        {
            var orgInfo = await _gitHubOrgService.GetOrgInfo(OrgName);

            Avatar = orgInfo.Icon;
            Name = orgInfo.DisplayName;
            Id = orgInfo.Id;
            Description = orgInfo.Description;
        }

    }
}
