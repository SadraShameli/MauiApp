using MauiApp1.View;

namespace MauiApp1;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(UserSignInPage), typeof(UserSignInPage));
        Routing.RegisterRoute(nameof(UserSignUpPage), typeof(UserSignUpPage));

        Routing.RegisterRoute(nameof(ItemDetailsPage), typeof(ItemDetailsPage));
    }
}
