using DocumentFormat.OpenXml.Bibliography;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventsMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogInPopUp
    {
        public LogInPopUp()
        {
            InitializeComponent();
        }

        private async  void SignInButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainMenuPage());
        }

        
    }
}