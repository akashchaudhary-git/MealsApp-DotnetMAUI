using Meals_App.ViewModels;

namespace Meals_App;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MyMealsViewModel();
	}

	
}

