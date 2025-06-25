using MauiApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class ShopViewModel : BaseViewModel
    {
        private readonly ApiService apiService;
        private readonly NavigationService navigationService;

        public ShopViewModel(ApiService apiService, NavigationService navigationService)
        {
            this.apiService = apiService;
            this.navigationService = navigationService;
            Text = "Shop page";
        }

        internal async Task GoToDetails()
        {
            await navigationService.NavigateToPage(typeof(ProductDetailsViewModel));
        }
    }
}
