using System;

using RealmFTW.ViewModels;

using Windows.UI.Xaml.Controls;

namespace RealmFTW.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
