using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Core;
using WpfApp1.Service.Interfaces;

namespace WpfApp1.ViewModel
{
    public class MainViewModel:BaseViewModel,INotifyPropertyChanged
    {

        //private BaseViewModel currentViewModel;
       //public BaseViewModel CurrentViewModel { get => currentViewModel; set { currentViewModel = value;OnPropertyChanged(); } } //=new AboutViewModel();
        public RelayCommand NavigateToAboutCommand { get; }
        public RelayCommand NavigateToHomeCommand { get; }
        public RelayCommand NavigateToSettingsCommand { get; }
        public INavigateService NavigateService { get;}
        public MainViewModel(INavigateService navigateService)
        {
            NavigateService = navigateService;
            NavigateToAboutCommand = new RelayCommand(_ => navigateService.NavigateTo<AboutViewModel>());
            NavigateToHomeCommand = new RelayCommand(_ => navigateService.NavigateTo<HomeViewModel>());
            NavigateToSettingsCommand = new RelayCommand(_ => navigateService.NavigateTo<SettingsViewModel>());  // New command
            NavigateToHomeCommand.Execute(null);  // Set default to Home page
        }

        //private void NavigateToAbout(object?obj) { CurrentViewModel =new AboutViewModel(); }
        //private void NavigateToHome(object? obj) { CurrentViewModel = new HomeViewModel(); }
        // public event PropertyChangedEventHandler? PropertyChanged;
        //public void OnPropertyChanged([CallerMemberName] string propertyName = "")=>PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


    }
}
