using MauiApp1.ViewModels;

namespace MauiApp1;

public static class MauiProgram
{
    public static MauiAppBuilder Builder { get; private set; }

    public static MauiApp CreateMauiApp()
	{
		Builder = MauiApp.CreateBuilder();
        Builder
            .UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        Builder.Services.AddSingleton<FuelAmountViewModel, FuelAmountViewModel>();
        Builder.Services.AddSingleton<CompositeViewModel, CompositeViewModel>();

		return Builder.Build();
	}
}
