using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab_4.Models;

public class WeatherInfo : INotifyPropertyChanged
{
    private WeatherType _condition;
    public WeatherType Condition
    {
        get => _condition;
        set { _condition = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}