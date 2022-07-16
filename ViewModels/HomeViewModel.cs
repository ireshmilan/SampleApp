using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject 
    {
        private INavigationService  _navigationService;

        [RelayCommand]
        public void UserInfo()
        {
            _navigationService.CreateBuilder().AddSegment<GitHubUserInfoViewModel>().Navigate();
        }
        [RelayCommand]
        public void OrgInfo()
        {
            _navigationService.CreateBuilder().AddSegment<GitHubOrgInfoViewModel>().Navigate();

        }

        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

        }
    }


}