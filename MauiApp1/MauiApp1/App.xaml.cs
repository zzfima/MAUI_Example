using MauiApp1.ViewModels;

namespace MauiApp1;

public partial class App : Application
{
	public App(CompositeViewModel compositeViewModel)
	{
		InitializeComponent();

		MainPage = new AppShell();
		MainPage.BindingContext = compositeViewModel;
	}
}
