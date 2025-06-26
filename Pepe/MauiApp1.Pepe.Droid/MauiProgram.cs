namespace MauiApp1.Pepe.Droid
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseSharedMauiApp(Systems.Pepe);

            return builder.Build();
        }
    }
}
