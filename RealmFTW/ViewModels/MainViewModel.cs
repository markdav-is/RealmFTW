using System;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using RealmFTW.Services;

namespace RealmFTW.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public RelayCommand GetReposCommand { get; set; }

        public MainViewModel(NetDataService netDataService, RealmService realmService)
        {
            GetReposCommand = new RelayCommand(() => {
                var repos = netDataService.GetRepos("https://api.github.com/users/nohorse/repos");
                realmService.WriteRepos(repos);
            });
        }
    }
}
