using ReactiveUI;
using Sextant;
using Sextant.Maui;
using Splat;

namespace SextantNavigation;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Locator
            .CurrentMutable
            .RegisterNavigationView(() => new NavigationView(RxApp.MainThreadScheduler, RxApp.TaskpoolScheduler, ViewLocator.Current))
            .RegisterParameterViewStackService()
            .RegisterViewForNavigation(() => new MainPage(), () => new MainViewModel())
            .RegisterViewForNavigation(() => new LogedInPage(), () => new LogedInViewModel());

        Locator
            .Current
            .GetService<IParameterViewStackService>()
            .PushPage<MainViewModel>(resetStack: true)
            .Subscribe();

        MainPage = Locator.Current.GetNavigationView("NavigationView");
    }
}

