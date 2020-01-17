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
    public partial class MainMenuPageDetail : ContentPage
    {
        public MainMenuPageDetail()
        {
            InitializeComponent();
        }

      //This only works for one image per screen   

       private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
       {
           Navigation.PushModalAsync(new Checkin());
       }

       

       // private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
       // {
       //    throw new NotImplementedException();
       // }

       //private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
       // {
       //     throw new NotImplementedException();

     //  private void TapGestureRecognizer_OnTapped(object sender, EventArgs e)
       //{
       //    Navigation.PushModalAsync(new Headsets());
       //}
    }
    }
