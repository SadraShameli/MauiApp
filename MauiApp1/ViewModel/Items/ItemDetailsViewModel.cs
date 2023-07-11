using CommunityToolkit.Mvvm.ComponentModel;
using MauiApp1.Model.Item;
using MauiApp1.Services;

namespace MauiApp1.ViewModel
{
    [QueryProperty(nameof(Item), nameof(Item))]
    public partial class ItemDetailsViewModel : BaseViewModel
    {
        ItemsService itemsService;

        [ObservableProperty]
        Item item;



        public ItemDetailsViewModel(ItemsService itemsService)
        {
            Title = "Details";
            this.itemsService = itemsService;
            Item = item;
        }
    }
}
