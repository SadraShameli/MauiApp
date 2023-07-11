using MauiApp1.ViewModel;

namespace MauiApp1.View;

public partial class UserSignUpPage : ContentPage
{
    public UserSignUpPage(UserSignUpViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}