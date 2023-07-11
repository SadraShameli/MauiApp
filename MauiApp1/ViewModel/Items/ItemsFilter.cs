using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.Model.Item;
using MauiApp1.Services;
using System.Collections.ObjectModel;

namespace MauiApp1.ViewModel
{
    public partial class ItemsFilterViewModel : BaseViewModel
    {
        private readonly ItemsService itemsService;

        public ObservableCollection<Item> Items { get; } = new();


        [ObservableProperty]
        private bool isRefreshing;


        public ItemsFilterViewModel(ItemsService itemsService)
        {
            Title = "Global Filter";
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
    }
}
