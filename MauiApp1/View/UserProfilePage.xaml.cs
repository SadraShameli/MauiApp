using MauiApp1.ViewModel;

namespace MauiApp1.View;

public partial class UserProfilePage : ContentPage
{
    public UserProfilePage(UserSignInViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}