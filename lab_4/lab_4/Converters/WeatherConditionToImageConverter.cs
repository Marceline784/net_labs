using System.Globalization;
using lab_4.Models;

namespace lab_4.Converters;

public class WeatherConditionToImageConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is WeatherType weather)
        {
            return weather switch
            {
                WeatherType.Sunny => ImageSource.FromFile("sunny.png"),
                WeatherType.Cloudy => ImageSource.FromFile("cloud.png"),
                _ => null
            };
        }
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) =>
        throw new NotImplementedException();
}