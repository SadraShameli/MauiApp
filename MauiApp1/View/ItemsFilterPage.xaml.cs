using MauiApp1.ViewModel;

namespace MauiApp1.View;

public partial class ItemsFilterPage : ContentPage
{
    public ItemsFilterPage(ItemsFilterViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}

