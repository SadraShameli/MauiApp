using MauiApp1.ViewModel;

namespace MauiApp1.View;

public partial class ItemDetailsPage : ContentPage
{
    public ItemDetailsPage(ItemDetailsViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}