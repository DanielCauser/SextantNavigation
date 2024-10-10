using ReactiveUI;

namespace SextantNavigation;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

        Logintbtn.Command = ReactiveCommand.CreateFromTask(() =>
        {
            var loginPage = App.NavigationManager.Navigation.NavigationStack[0];


            App.NavigationManager.Navigation.InsertPageBefore(new MainPage(), App.NavigationManager.Navigation.NavigationStack[0]);
            return App.NavigationManager.Navigation.PopToRootAsync(false);
        });

    }
}
