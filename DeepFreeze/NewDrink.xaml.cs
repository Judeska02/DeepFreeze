namespace DeepFreeze;

public partial class NewDrink : ContentPage
{
    public NewDrink()
    {
        InitializeComponent();
    }

    private void OnAddDrinkClicked(object sender, EventArgs e)
    {
        // Validatie van invoer
        if (!string.IsNullOrWhiteSpace(DrinkNameEntry.Text) && int.TryParse(DrinkAmountEntry.Text, out int amount))
        {
            // Voeg de nieuwe drank toe en keer terug naar de Fridge-pagina
            if (Application.Current.MainPage is NavigationPage navigationPage &&
                navigationPage.CurrentPage is Fridge fridgePage)
            {
                fridgePage.Drinks.Add(new Drink { Name = DrinkNameEntry.Text, Amount = amount });
                Navigation.PopAsync();
            }
        }
        else
        {
            DisplayAlert("Error", "Please enter valid drink information.", "OK");
        }
    }
}
