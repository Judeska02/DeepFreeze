namespace DeepFreeze;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private void FridgeButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Fridge());
    }
    private void BalanceButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Balance());
    }
    private void MessageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Message());
    }
    private void SettingsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Settings());
    }
}