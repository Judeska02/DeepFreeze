using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DeepFreeze;

public partial class Fridge : ContentPage
{
    public ObservableCollection<Drink> Drinks { get; set; }

    public Fridge()
    {
        InitializeComponent();

        // Dummy data
        Drinks = new ObservableCollection<Drink>
        {
            new Drink { Name = "Drink 1", Amount = 10 },
            new Drink { Name = "Drink 2", Amount = 7 },
            new Drink { Name = "Drink 3", Amount = 4 },
            new Drink { Name = "Drink 4", Amount = 5 },
            new Drink { Name = "Drink 5", Amount = 1 }
        };

        DrinkCollection.ItemsSource = Drinks;
    }

    private void AddDrinkButton_Clicked(object sender, EventArgs e)
    {
        // Navigate to NewDrink page
        Navigation.PushAsync(new NewDrink());
    }

    private void OnIncrementClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is Drink drink)
        {
            drink.Amount++;
        }
    }

    private void OnDecrementClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.BindingContext is Drink drink)
        {
            if (drink.Amount > 0)
                drink.Amount--;
        }
    }
}

public class Drink : INotifyPropertyChanged
{
    private int _amount;
    public string Name { get; set; }
    public int Amount
    {
        get => _amount;
        set
        {
            if (_amount != value)
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}

