using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;


using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace flashCards.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class flashCardMain : TabbedPage
    {
        public ObservableCollection<Profile> _Profiles = new ObservableCollection<Profile>();



        public flashCardMain()
        {
            
            InitializeComponent();
           

            CardBinding();
            BindingContext = this;
            
        }

        string ad;
        string soyad;
       
        
        
        
        

        
        public void CardBinding()
        {
           
            ArrayList myDicCollectionList = new ArrayList();
            myDicCollectionList.Add("değişmek");
            myDicCollectionList.Add("switch");

            ad = myDicCollectionList[1].ToString();
            soyad = myDicCollectionList[0].ToString();



            //_Profiles.Add(new Profile() { name = "Understand", surName = "Anlamak"});
            //_Profiles.Add(new Profile() { name = "Understand", surName = "Anlamak" });
            _Profiles.Add(new Profile() { name = ad, surName = soyad });
            _Profiles.Add(new Profile() { name = "Understand", surName = "Anlamak" });

        }
        public ObservableCollection<Profile> Profiles
        {

            get => _Profiles;
            set
            {
                _Profiles = value;
            }

        }

        public class Profile
        {
           
            //public static Dictionary<string, string> myDicCollectionList = new Dictionary<string, string>();

            public string name { get; set; }
            public string surName { get; set; }

            //public void randomWord()
            //{
            //    myDicCollectionList.Add("switch", "değişmek");
            //    foreach (KeyValuePair<string, string> myDicList in myDicCollectionList)
            //    {
            //        name = myDicList.Key;
            //        surName = myDicList.Value;
            //    }
            //}


        }

        private async void vocabularyButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new myWords());
        }

        public void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var label1 = (Label)sender;
           
            
            if (label1.Text == ad)
            {
                label1.Text = soyad;
            }
            else
            {
                label1.Text = ad;
            }
        }

        public async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            
          
            

        }

        async void plusImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new addingWord());
        }
    }
}