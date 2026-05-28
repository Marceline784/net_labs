using Microsoft.Maui.ApplicationModel.Communication;

namespace lab_1;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCallClicked(object sender, EventArgs e)
    {
        string number = PhoneEntry?.Text?.Trim() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(number))
        {
            await DisplayAlert("Помилка", "Будь ласка, введіть номер телефону", "OK");
            return;
        }

        bool isConfirmed = await DisplayAlert(
            "Підтвердження виклику",
            $"Ви впевнені, що хочете зателефонувати на {number}?",
            "Так", "Ні");

        if (isConfirmed)
        {
            try
            {
                if (PhoneDialer.Default.IsSupported)
                {
                    PhoneDialer.Default.Open(number);
                }
                else
                {
                    await DisplayAlert("Помилка", "Цей пристрій не підтримує виклики.", "OK");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Помилка", $"Сталася помилка: {ex.Message}", "OK");
            }
        }
    }
}