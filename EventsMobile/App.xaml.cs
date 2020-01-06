using System;
using EventsMobile;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventsMobile
{
    public partial class App : Application
    {
        public static MainPage PageMain { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
