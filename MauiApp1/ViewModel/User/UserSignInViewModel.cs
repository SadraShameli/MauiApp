﻿using CommunityToolkit.Mvvm.Input;
using MauiApp1.Model.Item;
using MauiApp1.View;

namespace MauiApp1.ViewModel
{
    [QueryProperty(nameof(Item), nameof(Item))]
    public partial class UserSignInViewModel : BaseViewModel
    {
        public UserSignInViewModel()
        {
            Title = "Sign in";
        }

        [RelayCommand]
        async Task GoToSignUpPage()
        {
            await Shell.Current.GoToAsync($"{nameof(UserSignUpPage)}", true);
        }
    }
}
