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
            BindingContext = new CommunityViewModel();
        }

    }
}