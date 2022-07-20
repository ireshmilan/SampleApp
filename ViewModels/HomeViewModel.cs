using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SampleApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModels
{
    public partial class HomeViewModel : ObservableObject 
    {
        [ObservableProperty]
        public ObservableCollection<ShoppingItem> _items = new ObservableCollection<ShoppingItem>();
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
            Items.Add(new ShoppingItem { Name = "Soap", Price = 200, Description = "Baby Soap" });
            Items.Add(new ShoppingItem { Name = "Oil", Price = 800, Description = "Olive Soap" });
            Items.Add(new ShoppingItem { Name = "Chocolate", Price = 200, Description = "DArk Chocolate" });
        }
    }


}