using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
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
        public void CardBinding()
        {
            _Profiles.Add(new Profile() { Name="berkay", Age="18", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "turgut", Age = "30", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "tugce  ", Age = "24", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "halime", Age = "52", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "selin", Age = "10", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "mine", Age = "54", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "berkay", Age = "18", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "turgut", Age = "30", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "tugce  ", Age = "24", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "halime", Age = "52", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "selin", Age = "10", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "mine", Age = "54", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "berkay", Age = "18", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "turgut", Age = "30", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "tugce  ", Age = "24", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "halime", Age = "52", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "selin", Age = "10", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "mine", Age = "54", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "berkay", Age = "18", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "turgut", Age = "30", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "tugce  ", Age = "24", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "halime", Age = "52", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "selin", Age = "10", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "mine", Age = "54", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "berkay", Age = "18", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "turgut", Age = "30", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "tugce  ", Age = "24", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "halime", Age = "52", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "selin", Age = "10", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "mine", Age = "54", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "berkay", Age = "18", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "turgut", Age = "30", Photo = "icon.png" });
            _Profiles.Add(new Profile() { Name = "tugce  ", Age = "24", Photo = "icon.png" });
           
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
            public string Name { get; set; }
            public string Age { get; set; }
            public string Photo { get; set; }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new myWords());
        }
    }
}