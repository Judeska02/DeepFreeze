namespace DeepFreeze;

public partial class LogInPage : ContentPage
{
	public LogInPage()
	{
		InitializeComponent();
	}
    private void LogInButton_Clicked(object sender, EventArgs e)
    {
        bool IsUserNameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
        bool IsPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

        if (IsUserNameEmpty)
        {
            UsernameEntry.Placeholder = "Vul je username in!";
        }

        else if (IsPasswordEmpty)
        {
            PasswordEntry.Placeholder = "Vul je wachtwoord in!";
        }

        else
        {
            Navigation.PushAsync(new HomePage());
        }
    }
}