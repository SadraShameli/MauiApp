using MauiApp1.View;

namespace MauiApp1;

internal static class Globals
{
    public static bool IsFirstStartup = Preferences.Default.Get(nameof(IsFirstStartup), true);
}


public partial class App : Application
{

    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override void OnStart()
    {
        base.OnStart();

        if (Globals.IsFirstStartup)
        {
            _ = Shell.Current.GoToAsync($"{nameof(ItemsFilterPage)}", true);
        }
    }
}