using FuelSitesUI.Services;

namespace FuelSitesUI;

public partial class MainPage : ContentPage
{
	//string username;
	//string password;

	public MainPage(UserLoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}


	
}

