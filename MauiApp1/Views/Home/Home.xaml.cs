using MauiApp1.ViewModels;

namespace MauiApp1.Views.Home;

public partial class Home : ContentPage
{
    int count = 0;
    public Home(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        BindingContext = homeViewModel;
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {

        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}