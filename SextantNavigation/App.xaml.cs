using ReactiveUI;
using Splat;

namespace SextantNavigation;

public partial class App : Application
{

    public static Action<Type> RootNavigation;
    public static NavigationPage NavigationManager;


    public App()
	{
		InitializeComponent();

        NavigationManager = new NavigationPage(new LoginPage());
        MainPage = NavigationManager;
    }
}

