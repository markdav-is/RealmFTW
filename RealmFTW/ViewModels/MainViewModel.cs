using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;

namespace RealmFTW.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand GetReposCommand;

        public MainViewModel()
        {
            GetReposCommand = new RelayCommand(() => {

            });
        }
    }
}
