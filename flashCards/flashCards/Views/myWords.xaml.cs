using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace flashCards.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class myWords : ContentPage
    {
       
            public myWords()
        {

            InitializeComponent();
            
           
        }

        protected override async void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                myCollectionView.ItemsSource = await App.MyDatabase.ReadVocabulary();
            }
            catch { }

        }


    }
}