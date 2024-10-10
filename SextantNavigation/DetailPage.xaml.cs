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
            App.NavigationManager.Navigation.InsertPageBefore(new LoginPage(), App.NavigationManager.Navigation.NavigationStack[0]);
            return App.NavigationManager.Navigation.PopToRootAsync(false);
		});

    }
}
