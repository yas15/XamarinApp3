using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new App3.View.MainPage();


            // MainPage is a property of the application class and is of type Page
            // The MainPage is the initial Xamarin.Forms page that will be launched by the appliaction
            // We can set the MainPage property to any object of type page.
            // new NavigationPage(new View.MainPage()) - Creates a new NavigationPage with View.MainPage() as its root element.
            // Since we have set the MainPage property to a new NavigationPage, 
            // we can now start to use NavigationPage methods on the object MainPage
            MainPage = new NavigationPage(new View.MainPage());

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
