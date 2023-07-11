using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Model.Item;
using MauiApp1.Services;
using MauiApp1.View;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModel
{
    public partial class ItemsViewModel : BaseViewModel
    {
        private readonly ItemsService itemsService;

        public ObservableCollection<Item> Items { get; } = new();


        [ObservableProperty]
        private bool isRefreshing;


        public ItemsViewModel(ItemsService itemsService)
        {
            Title = "Items";
            this.itemsService = itemsService;
        }

        [RelayCommand]
        private async Task GetItems()
        {
            if (IsBusy)
            {
                return;
            }

            try
            {
                IsBusy = true;
                List<Item> items = await itemsService.GetItems();

                if (Items.Count != 0)
                {
                    Items.Clear();
                }

                foreach (Item item in items)
                {
                    Items.Add(item);
                }

            }

            catch (Exception)
            {

            }

            finally
            {
                IsBusy = false;
                IsRefreshing = false;
            }
        }

        [RelayCommand]
        private void FilterItems()
        {
            // Modify items collection or return a filtered list
        }

        [RelayCommand]
        private async Task GoToItemDetailsPage(Item item)
        {
            if (item is null)
            {
                return;
            }

            await Shell.Current.GoToAsync($"{nameof(ItemDetailsPage)}", true, new Dictionary<string, object> { { nameof(Item), item } });
        }

        [RelayCommand]
        private async Task GoToSignInPage()
        {
            await Shell.Current.GoToAsync($"{nameof(UserSignInPage)}", true);
        }
    }
}
