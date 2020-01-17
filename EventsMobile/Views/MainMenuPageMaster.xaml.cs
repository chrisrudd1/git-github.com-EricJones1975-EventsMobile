using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EventsMobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainMenuPageMaster : ContentPage
    {
        public ListView ListView;

        public MainMenuPageMaster()
        {
            InitializeComponent();

            BindingContext = new MainMenuPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MainMenuPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MainMenuPageMasterMenuItem> MenuItems { get; set; }

            public MainMenuPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MainMenuPageMasterMenuItem>(new[]
                {
                    new MainMenuPageMasterMenuItem { Id = 1, Title = "Change Web connection " },
                    new MainMenuPageMasterMenuItem { Id = 2, Title = "Sync Data" },
                    new MainMenuPageMasterMenuItem { Id = 3, Title = "Training Mode" },
                    new MainMenuPageMasterMenuItem { Id = 4, Title = "Help" },
                    new MainMenuPageMasterMenuItem { Id = 5, Title = "Contact Us!" },
                    new MainMenuPageMasterMenuItem { Id = 5, Title = "Log Out" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}