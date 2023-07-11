using MauiApp1.Services;
using MauiApp1.View;
using MauiApp1.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiApp1;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        MauiAppBuilder builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf");
                fonts.AddFont("OpenSans-Semibold.ttf");
                fonts.AddFont("MaterialIconsOutlined-Regular.otf");
                fonts.AddFont("MaterialIcons-Regular.ttf");
                fonts.AddFont("MaterialSymbols-Outlined.ttf");
            });


        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton<UserSignInPage>();
        builder.Services.AddSingleton<UserSignInViewModel>();
        builder.Services.AddSingleton<UserSignUpPage>();
        builder.Services.AddSingleton<UserSignUpViewModel>();
        builder.Services.AddSingleton<UserProfilePage>();
        builder.Services.AddSingleton<UserProfileViewModel>();

        builder.Services.AddSingleton<ItemsService>();
        builder.Services.AddSingleton<ItemsViewModel>();
        builder.Services.AddTransient<ItemDetailsPage>();
        builder.Services.AddTransient<ItemDetailsViewModel>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
