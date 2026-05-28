namespace lab_3;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Calculate()
    {
        if (double.TryParse(billInput.Text, out double bill))
        {
            var tip = bill * (tipPercentSlider.Value / 100);
            var total = bill + tip;

            tipOutput.Text = tip.ToString("C2");
            totalOutput.Text = total.ToString("C2");
        }
    }

    private void OnAmountChanged(object sender, TextChangedEventArgs e) => Calculate();
    private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
    {
        tipPercent.Text = $"{Math.Round(e.NewValue)}%";
        Calculate();
    }

    private void OnNormalTip(object sender, EventArgs e) => tipPercentSlider.Value = 15;
    private void OnGenerousTip(object sender, EventArgs e) => tipPercentSlider.Value = 20;

    private void OnRoundDownClicked(object sender, EventArgs e)
    {
        if (double.TryParse(billInput.Text, out double bill))
        {
            var total = bill + (bill * (tipPercentSlider.Value / 100));
            totalOutput.Text = Math.Floor(total).ToString("C2");
        }
    }

    private void OnRoundUpClicked(object sender, EventArgs e)
    {
        if (double.TryParse(billInput.Text, out double bill))
        {
            var total = bill + (bill * (tipPercentSlider.Value / 100));
            totalOutput.Text = Math.Ceiling(total).ToString("C2");
        }
    }
}