using MauiApp1.Views.Shop;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("shop/details", typeof(ProductDetails));
        }
    }
}
