using System;

using RealmFTW.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RealmFTW.Views
{
    public sealed partial class ReposPage : Page
    {
        private ReposViewModel ViewModel
        {
            get { return DataContext as ReposViewModel; }
        }

        public ReposPage()
        {
            InitializeComponent();
            Loaded += ReposPage_Loaded;
        }

        private async void ReposPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }
    }
}
