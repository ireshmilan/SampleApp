using RestEase.HttpClientFactory;
using SampleApp.RestServices;
using SampleApp.Services;
using SampleApp.Services.Abstractions;
using SampleApp.ViewModels;
using SampleApp.Views;

namespace SampleApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
        var builder = MauiApp.CreateBuilder();
		builder
            .UsePrismApp<App>(prism =>
            {
				prism.RegisterTypes(container =>
				{
					container.Register<IGitHubUserService, GitHubUserService>();
                    container.Register<IGitHubOrgService, GitHubOrgService>();

                    container.RegisterForNavigation<GitHubUserInfoView, GitHubUserInfoViewModel>();
                    container.RegisterForNavigation<HomeView, HomeViewModel>();
                    container.RegisterForNavigation<GitHubOrgInfoView, GitHubOrgInfoViewModel>();
                })
				.ConfigureServices(service =>
                {
					service.AddRestEaseClient<IGitHubApiService>("https://api.github.com");
                })
				.OnAppStart(navigationService => navigationService.CreateBuilder()
				.AddNavigationPage().AddSegment<HomeViewModel>().Navigate());
            })
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}

