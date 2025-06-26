using MauiApp1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Services
{
    public class NavigationService
    {
        Dictionary<Type, string> Pages = new Dictionary<Type, string>
            {
                { typeof(ProductDetailsViewModel), "shop/details" }
            };
        public NavigationService()
        {
        }

        public async Task NavigateToPage(Type viewmodel)
        {
            if (Pages.TryGetValue(viewmodel, out var page))
            {
                await Shell.Current.GoToAsync(page);
            }
        }
    }
}
