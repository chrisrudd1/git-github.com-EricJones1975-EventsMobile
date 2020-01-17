using System;
using System.IO;
using EventsMobile;
using EventsMobile.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventsMobile
{
    public partial class App : Application
    {
        static Database.Database database;
        public static Database.Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database.Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "fbo.db3"));
                }
                return database;
            }
        }

        public static MainPage PageMain { get; set; }
        public App()
        {
            InitializeComponent();

            MainPage = new MainMenuPage();
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
