using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CalcMobile.Views;

namespace CalcMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new CalculatorView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
