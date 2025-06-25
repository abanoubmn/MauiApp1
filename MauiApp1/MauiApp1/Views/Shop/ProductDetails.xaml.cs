using MauiApp1.ViewModels;

namespace MauiApp1.Views.Shop;

public partial class ProductDetails : ContentPage
{
    public ProductDetails(ProductDetailsViewModel productDetailsViewModel)
    {
        InitializeComponent();
        BindingContext = productDetailsViewModel;
    }
}