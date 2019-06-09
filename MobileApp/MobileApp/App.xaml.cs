using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp.Services;
using MobileApp.Views;
using System.Diagnostics;

namespace MobileApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
            Debug.WriteLine("My App is Started");
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            Current.Properties["username"] = "Joe";
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            var username = Current.Properties["username"];
            // Handle when your app resumes
        }
    }
}
