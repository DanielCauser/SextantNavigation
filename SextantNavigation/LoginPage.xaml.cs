using ReactiveUI;

namespace SextantNavigation;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

        Logintbtn.Command = ReactiveCommand.Create(() =>
        {
            App.RootNavigation.Invoke(typeof(MainPage));
        });

    }
}
