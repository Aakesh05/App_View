using App_Views.Pages;

namespace App_Views;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Pages.CarouselView();
	}
}
