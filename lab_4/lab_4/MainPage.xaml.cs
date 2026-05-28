using lab_4.Models;

namespace lab_4;

public partial class MainPage : ContentPage
{
    WeatherInfo weatherData = new WeatherInfo { Condition = WeatherType.Sunny };

    public MainPage()
    {
        InitializeComponent();
        BindingContext = weatherData;
    }

    private void OnRefreshClicked(object sender, EventArgs e)
    {
        if (WeatherPicker.SelectedItem != null)
        {
            if (Enum.TryParse(WeatherPicker.SelectedItem.ToString(), out WeatherType newCondition))
            {
                weatherData.Condition = newCondition;
            }
        }
    }
}