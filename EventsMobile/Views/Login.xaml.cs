using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventsMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Login_button_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuPage());
        }
    }
}