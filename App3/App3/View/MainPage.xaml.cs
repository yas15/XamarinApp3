using System;
using App3.Model;
using App3.ViewModel;
using Xamarin.Forms;

namespace App3.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // set the BindingContext Property of the view MainPage to a new instance of the MainPage ViewModel.
            // i.e. set the default datasource for all the objects in the MainPage View to the objects in the MainPageViewModel.
            BindingContext = new MainPageViewModel();

        }

        // EventHandler for the ItemSelected event
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;  // catch deselection
            }

            Person person = e.SelectedItem as Person;

            // DisplayAlert() is Xamarin.Forms.Page equivalent of the MessageBox()
            DisplayAlert("Selected", person.LastName, "OK");

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page1());
        }
    }
}
