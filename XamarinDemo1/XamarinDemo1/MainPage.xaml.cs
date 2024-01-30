using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinDemo1
{
    public partial class MainPage : ContentPage
    {
        public string Fruit { get; set; }

        public MainPage()
        {
            InitializeComponent();
            Fruit = Helpers.AppSettings.fruit;
            BindingContext = this;
        }
    }
}

