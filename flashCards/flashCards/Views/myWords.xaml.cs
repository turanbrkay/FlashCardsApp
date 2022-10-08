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
            List<vocabularyInfo> myList = new List<vocabularyInfo>
            {
                new vocabularyInfo { Name = "berkay", Age = "18" },
                new vocabularyInfo { Name = "Suat", Age = "24" }
            };
            myListView.ItemsSource = myList;
        }

        class vocabularyInfo
        {
            public string Name { get; set; }
            public string Age { get; set; }

        }
    }
}