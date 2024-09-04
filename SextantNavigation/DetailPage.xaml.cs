using ReactiveUI;
using ReactiveUI.Maui;

namespace SextantNavigation;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();

		Logoutbtn.Command = ReactiveCommand.Create(() =>
		{
			App.RootNavigation.Invoke( typeof(LoginPage));
		});

    }
}
