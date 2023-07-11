using CommunityToolkit.Mvvm.Input;
using MauiApp1.Model.Item;
using MauiApp1.View;

namespace MauiApp1.ViewModel
{
    [QueryProperty(nameof(Item), nameof(Item))]
    public partial class UserProfileViewModel : BaseViewModel
    {
        public UserProfileViewModel()
        {
            Title = "User Profile";
        }

        [RelayCommand]
        private async Task GoToSignUpPage()
        {
            await Shell.Current.GoToAsync($"{nameof(UserProfilePage)}", true);
        }
    }
}
