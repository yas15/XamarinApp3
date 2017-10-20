using System;
using App3.ViewModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            // set the BindingContext Property of the view Page1 to a new instance of the Page1 ViewModel.
            // i.e. set the default datasource for all the objects in Page1 View to the objects in the Page1ViewModel.
            BindingContext = new Page1ViewModel();
        }
    }
}