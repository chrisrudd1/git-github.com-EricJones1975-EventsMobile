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

        private void IssueButton_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Issue Headsets", "Do you want to issue these headsets?", "Yes", "No");
        }


        private void ReturnButton_OnClicked(object sender, EventArgs e)
        {
            DisplayAlert("Return Headsets", "Do you want to return these headsets?", "Yes", "No");
        }
    }
}