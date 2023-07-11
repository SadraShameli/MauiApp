using MauiApp1.ViewModel;

namespace MauiApp1.View;

public partial class UserSignInPage : ContentPage
{
    public UserSignInPage(UserSignInViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}