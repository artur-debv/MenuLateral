using MauiApp_Flyout.Pages;

namespace MauiApp_Flyout;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//MainPage = new AppShell();
		MainPage = new MenuPage();
	}
}
