using flashCards.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace flashCards
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new flashCardMain();
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
