namespace lab_2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    
    private async void OnSaveClicked(object sender, EventArgs e)
    {
        string name = NameEntry.Text;

        if (!string.IsNullOrWhiteSpace(name))
        {
            MessageLabel.Text = $"Вітаємо, {name}! Дані збережено.";
            MessageLabel.TextColor = Colors.DarkGreen;

            
            await SaveBtn.ScaleTo(0.95, 100);
            await SaveBtn.ScaleTo(1.0, 100);
        }
        else
        {
            await DisplayAlert("Помилка", "Будь ласка, введіть ім'я.", "OK");
        }
    }
}