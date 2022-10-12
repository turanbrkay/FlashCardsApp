using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace flashCards.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class addingWord : ContentPage
    {
        public addingWord()
        {
            InitializeComponent();
        }

        async void addingButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mean.Text) || string.IsNullOrWhiteSpace(word.Text)) 
            {
                await DisplayAlert("invalid", "Blank or WhiteSpace value is invalid", "ok");
            }
            else
            {
                AddNewVocabulary();
            }
        }
        async void AddNewVocabulary()
        {
            await App.MyDatabase.CreateVocabulary(new Model.vocabularyModel
            {
                Name = word.Text,
                Surname = mean.Text
            });
            await Navigation.PopAsync();
        }
    }
}