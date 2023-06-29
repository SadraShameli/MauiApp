using MauiApp1.ViewModel;

namespace MauiApp1.View;

public partial class ItemsDetailPage : ContentPage
{
    public ItemsDetailPage(ItemsDetailViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}