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




    }
}
