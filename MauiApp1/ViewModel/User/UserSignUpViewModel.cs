using CommunityToolkit.Mvvm.Input;
using MauiApp1.Model.Item;

namespace MauiApp1.ViewModel
{
    [QueryProperty(nameof(Item), nameof(Item))]
    public partial class UserSignUpViewModel : BaseViewModel
    {
        public UserSignUpViewModel()
        {
            Title = "Sign up";
        }

        [RelayCommand]
        async Task GoToSignUpPage()
        {
            await Shell.Current.GoToAsync($"{nameof(UserSignUpViewModel)}", true);
        }
    }
}
