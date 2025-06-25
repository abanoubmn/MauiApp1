using MauiApp1.Services;
using MauiApp1.ViewModels;
using MauiApp1.Views.Home;
using MauiApp1.Views.Shop;
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
    public static class MauiProgramExtensions
    {
        public static MauiAppBuilder UseSharedMauiApp(this MauiAppBuilder builder)
        {
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            builder.Services.AddSingleton<ApiService>();
            builder.Services.AddSingleton<NavigationService>();

            builder.Services.AddScoped<HomeViewModel>();
            builder.Services.AddScoped<Home>();

            builder.Services.AddScoped<ShopViewModel>();
            builder.Services.AddScoped<Shop>();


            builder.Services.AddScoped<ProductDetailsViewModel>();
            builder.Services.AddScoped<ProductDetails>();
#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder;
        }
    }
}
