using CommunityToolkit.Maui;
using PetaversePortal.Interfaces;
using PetaversePortal.Services;
using PetaversePortal.ViewModels;
using PetaversePortal.Pages;

namespace PetaversePortal;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("FluentSystemIcons-Regular.ttf", "FluentUIFont");
            });

        builder.UseMauiApp<App>().UseMauiCommunityToolkit();

        builder.Services.AddSingleton<ISpeciesService, SpeciesService>();
        builder.Services.AddSingleton<IBreedService, BreedService>();

        //ViewModels
        builder.Services.AddTransient<ViewModelBase>();
        builder.Services.AddTransient<SpeciesViewModel>();

        //Page
        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<BreedPage>();
        builder.Services.AddTransient<SpeciesPage>();

        return builder.Build();
	}
}
