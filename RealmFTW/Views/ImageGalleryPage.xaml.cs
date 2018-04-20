using System;

using RealmFTW.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace RealmFTW.Views
{
    public sealed partial class ImageGalleryPage : Page
    {
        private ImageGalleryViewModel ViewModel
        {
            get { return DataContext as ImageGalleryViewModel; }
        }

        public ImageGalleryPage()
        {
            InitializeComponent();
        }

        private async void GridView_Loaded(object sender, RoutedEventArgs e)
        {
            var gridView = sender as GridView;
            await ViewModel.LoadAnimationAsync(gridView);
        }
    }
}
