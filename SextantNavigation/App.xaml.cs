using ReactiveUI;
using Splat;

namespace SextantNavigation;

public partial class App : Application
{
    public static Action<Type> RootNavigation;

	public App()
	{
		InitializeComponent();

        RootNavigation = (Type type) =>
        {
            if (type.Name == nameof(MainPage))
            {
                MainPage = new MainPage();
            }
            else
            {
                MainPage = new LoginPage();
            }
        };

        RootNavigation.Invoke(typeof(MainPage));
    }
}

