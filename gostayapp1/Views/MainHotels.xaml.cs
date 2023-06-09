using gostayapp1;
using gostayapp1.Models;
using System.Windows.Input;

namespace gostayapp1.Views;

public partial class MainHotels : ContentPage
{
    public MainHotels()
    {
        InitializeComponent();
        DatePicker datePicker = new DatePicker
        {
            MinimumDate = new DateTime(2018, 1, 1),
            MaximumDate = new DateTime(2018, 12, 31),
            Date = new DateTime(2018, 6, 21)
        };
    }

    private async void SearchCollapse(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SearchCollapse());
    }

    private async void SelectRoom(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new SelectRoom());
    }

    //async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
    //{
    //    string catName = (e.CurrentSelection.FirstOrDefault() as Animal).Name;
    //    await Shell.Current.GoToAsync($"catdetails?name={catName}");
    //}

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Welcome());
    }
    private async void HotelListing(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HotelListing());
    }
}