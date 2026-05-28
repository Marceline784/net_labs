using lab_5.ViewModels;

namespace lab_5;

public partial class App : Application
{
    public static MovieListViewModel MainViewModel { get; private set; } = null!;

    public App()
    {
        InitializeComponent();
        MainViewModel = new MovieListViewModel();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }
}