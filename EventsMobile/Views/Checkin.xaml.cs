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
    public partial class Checkin : ContentPage
    {
        public Checkin()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}