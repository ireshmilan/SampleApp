using System;
using System.Diagnostics;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Prism.Common;
using SampleApp.Services.Abstractions;

namespace SampleApp.ViewModels
{
	public partial class GitHubUserInfoViewModel : ObservableObject
	{
		private IGitHubUserService _gitHubUserService;
        [ObservableProperty]
		private string _giHubuserName;

        [ObservableProperty]
        private string _avatar;

        [ObservableProperty]
        private string _displayName;

        [ObservableProperty]
        private string _country;

        [ObservableProperty]
        private string _bio;

        [RelayCommand]
		public async void GetMyInfo()
        {
			Debug.WriteLine(GiHubuserName);

            var userInfo = await _gitHubUserService.GetUserInfo(GiHubuserName);
            
            Avatar = userInfo.Avatar;
            DisplayName = userInfo.DisplayName;
            Bio = userInfo.Bio;
            Country = userInfo.Country;
        }

		public GitHubUserInfoViewModel(IGitHubUserService gitHubUserService)
		{
			_gitHubUserService = gitHubUserService;
		}
    }
}