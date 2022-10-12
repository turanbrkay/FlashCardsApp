using flashCards.Model;
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

        async void SwipeItem_Invoked(object sender, EventArgs e)
        {
            var item = sender as SwipeItem;
            var word = item.CommandParameter as vocabularyModel;
            var result = await DisplayAlert("Delete", $"{word.Name} will be deleted from database", "Yes", "No");
            if (result)
            {
                await App.MyDatabase.DeleteVocabulary(word);
                myCollectionView.ItemsSource = await App.MyDatabase.ReadVocabulary();
            }
        }
    }
}