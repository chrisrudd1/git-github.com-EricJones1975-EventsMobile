using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventsMobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : CarouselPage
    {
        public SplashPage()
        {
            InitializeComponent();
        }

        private async void Signin_OnClicked(object sender, EventArgs e)
        {
            var firstPage = new NavigationPage(new Login());
            await Navigation.PushModalAsync(firstPage);

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        //private async void Continue_OnClicked(object sender, EventArgs e)
        //{
        //    //var firstPage = new NavigationPage(new Login());
        //    await Navigation.PushAsync(new Login());
        //}
    }
}