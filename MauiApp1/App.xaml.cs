namespace MauiApp1
{
    public partial class App : Application
    {
        public App(Systems systems)
        {
            InitializeComponent();

            switch (systems)
            {
                case Systems.Pepe:
                    Resources.MergedDictionaries.Add(new Styles.PepeStyle());
                    break;
                case Systems.Oodles:
                    Resources.MergedDictionaries.Add(new Styles.OodlesStyle());
                    break;
            }

            MainPage = new AppShell();
        }
    }

    public enum Systems
    {
        Pepe,
        Oodles
    }
}
