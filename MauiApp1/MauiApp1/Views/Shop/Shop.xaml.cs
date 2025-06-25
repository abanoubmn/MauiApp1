using MauiApp1.ViewModels;

namespace MauiApp1.Views.Shop;

public partial class Shop : ContentPage
{
    public Shop(ShopViewModel shopViewModel)
    {
        InitializeComponent();
        this.BindingContext = shopViewModel;
    }

    private ShopViewModel _vm => BindingContext as ShopViewModel;

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await _vm.GoToDetails();
    }
}