namespace MauiApp1.Components;

public partial class NavBar : ContentView
{
    public NavBar()
    {
        InitializeComponent();
    }
    #region NavBarTitle : string
    public static readonly BindableProperty NavBarTitleProperty =
       BindableProperty.Create(nameof(NavBarTitle), typeof(string), typeof(NavBar), String.Empty, BindingMode.TwoWay);
    public string NavBarTitle
    {
        get
        {
            return (string)GetValue(NavBarTitleProperty);
        }
        set
        {
            SetValue(NavBarTitleProperty, value);
        }
    }
    #endregion
    #region LocationTitle
    public static readonly BindableProperty LocationTitleProperty =
     BindableProperty.Create(nameof(LocationTitle), typeof(string), typeof(NavBar), String.Empty, BindingMode.TwoWay);
    public string LocationTitle
    {
        get
        {
            return (string)GetValue(LocationTitleProperty);
        }
        set
        {
            SetValue(LocationTitleProperty, value);
        }
    }
    #endregion
}