using MauiApp1.ViewModels;

namespace MauiApp1.Views.Home;

public partial class Home : ContentPage
{
    public Home(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        BindingContext = homeViewModel;
    }
}