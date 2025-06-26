namespace MauiApp1.Oodles.iOS
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseSharedMauiApp(Systems.Oodles);

            return builder.Build();
        }
    }
}
