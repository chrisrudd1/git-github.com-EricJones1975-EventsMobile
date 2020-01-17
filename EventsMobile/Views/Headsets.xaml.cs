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
    public partial class Headsets : ContentPage
    {
        public Headsets()
        {
            InitializeComponent();
        }

        private void ReturnHeadsetsButton_OnPressed(object sender, EventArgs e)
        {
            DisplayAlert("Issue Headsets", "Would you like to issue headsets?", "Yes", "No");
        }

        private void IssueHeadsetsButton_OnPressed(object sender, EventArgs e)
        {
            DisplayAlert("Return Headsets", "Would you like to return headsets?", "Yes", "No");
        }
    }
}