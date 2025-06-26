using MauiApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        private readonly ApiService _apiService;

        public HomeViewModel(ApiService apiService)
        {
            this._apiService = apiService;
            Text = "Home page";
        }
    }
}
