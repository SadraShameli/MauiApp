using MauiApp1.Services;
using MauiApp1.View;
using MauiApp1.ViewModel;
using Microsoft.Extensions.Logging;

namespace MauiApp1;

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
                fonts.AddFont("MaterialIconsOutlined-Regular.otf", "MaterialIconsOutlined-Regular");
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons-Regular");
            });

        builder.Services.AddSingleton<ItemsService>();
        builder.Services.AddSingleton<ItemsViewModel>();
        builder.Services.AddTransient<ItemsDetailViewModel>();

        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddTransient<ItemsDetailPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
