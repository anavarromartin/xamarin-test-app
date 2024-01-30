using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinDemo1.Helpers;

namespace XamarinDemo1
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            MainPage = new MainPage();
            Console.WriteLine($"Fruit is {AppSettings.fruit}");
            Console.WriteLine($"foo is {Secrets.foo}");
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }
    }
}

