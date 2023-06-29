using System.Collections.ObjectModel;
using MauiApp1.Model.Item;
using MauiApp1.Services;
using CommunityToolkit.Mvvm.Input;
using MauiApp1.View;
using CommunityToolkit.Mvvm.ComponentModel;

namespace MauiApp1.ViewModel
{
    public partial class ItemsViewModel : BaseViewModel
    {
        ItemsService itemsService;

        public ObservableCollection<Item> Items { get; } = new();


        [ObservableProperty]
        bool isRefreshing;


        public ItemsViewModel(ItemsService itemsService)
        {
            Title = "Items";
            this.itemsService = itemsService;
        }

        [RelayCommand]
        async Task GetItems()
        {
            if (IsBusy)
                return;

            try
            {
                var items = await itemsService.GetItems();

                if (Items.Count != 0)
                    Items.Clear();


                foreach (var item in items)
                {
                    Items.Add(item);
                }

            }

            catch (Exception e)
            {

            }

            finally
            {
                IsBusy = false;
            }
        }

        [RelayCommand]
        async Task GoToItemsDetail(Item item)
        {
            if (item is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(ItemsDetailPage)}", true, new Dictionary<string, object> { { nameof(Item), item } });
        }

        [RelayCommand]
        void FilterItems()
        {
            // Modify items collection or return a filtered list
        }
    }
}
