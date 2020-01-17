using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventsMobile;
using EventsMobile.Database;
using EventsMobile.Models;
using Xamarin.Forms;

namespace EventsMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ListView.ItemsSource = await App.Database.GetFboAsync();
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(forenameEntry.Text) && !string.IsNullOrWhiteSpace(surnameEntry.Text))
            {
                await App.Database.SaveFboAsync(new Fbo
                {
                    Forename = forenameEntry.Text,
                    Surname = surnameEntry.Text
                });

                forenameEntry.Text = surnameEntry.Text = string.Empty;
                ListView.ItemsSource = await App.Database.GetFboAsync();
            }
        }
    }
}
