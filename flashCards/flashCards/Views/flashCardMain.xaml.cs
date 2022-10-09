using MLToolkit.Forms.SwipeCardView;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;

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
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });
            _Profiles.Add(new Profile() { Name = "true", Age = "18", Photo = "icon.png", visible = "true" });

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

            public string visible { get; set; }

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new myWords());
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            var label1 = (Label)sender;
            if (label1.Text == "myword")
            {
                label1.Text = "naberlan";
            }
            else
            {
                label1.Text = "myword";
            }
        }
    }
}