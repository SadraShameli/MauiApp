using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModel
{
    public partial class BaseViewModel : ObservableObject
    {
        public BaseViewModel()
        {

        }

        [ObservableProperty]
        bool isBusy;

        [ObservableProperty]
        string title;       
    }
}
