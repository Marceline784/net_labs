namespace lab_5.Views;

public partial class MoviesListPage : ContentPage
{
    public MoviesListPage()
    {
        InitializeComponent();
        BindingContext = App.MainViewModel;
    }
}