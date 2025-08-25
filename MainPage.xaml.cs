using DoggyPedia.Model;

namespace DoggyPedia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSearchQueryChanged(object sender, TextChangedEventArgs e)
        {
            DogBreeds.ItemsSource = string.IsNullOrWhiteSpace(e.NewTextValue) ? Data.DogData.Dogs 
                : Data.DogData.Dogs.Where(dog => dog.Name.Contains(e.NewTextValue, StringComparison.CurrentCultureIgnoreCase));
        }

        private async void OnDogSelectionChangedAsync(object sender, SelectionChangedEventArgs e)
        {
            if (DogBreeds.SelectedItem != null) 
            {
                Dog? dog = DogBreeds.SelectedItem as Dog;
                await Navigation.PushAsync(new InfoPage { BindingContext = dog });
                DogBreeds.SelectedItem = null;
            }       
        }
    }
}