using Microsoft.AppCenter.Crashes;
using Microsoft.AppCenter;

namespace SampleApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
	}

	protected override void OnStart()
	{
		base.OnStart();
        AppCenter.Start("ff91f5b9-f8ba-43e8-b818-1c1432288331", typeof(Crashes));
    }
}

