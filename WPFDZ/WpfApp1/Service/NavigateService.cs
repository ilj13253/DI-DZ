using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Core;
using WpfApp1.Service.Interfaces;

namespace WpfApp1.Service
{
    public class NavigateService(Func<Type,BaseViewModel> FactoryViewModel) : ObservableObject, INavigateService
    {
        private BaseViewModel? currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get => currentViewModel;
            private set
            {
                currentViewModel = value;
                OnPropertyChanged(); 
            }
        }

        // Method to handle navigation to a new ViewModel
        public void NavigateTo<TViewModel>() where TViewModel : BaseViewModel
        {
            CurrentViewModel= FactoryViewModel.Invoke(typeof(TViewModel));
            //CurrentViewModel = Activator.CreateInstance<TViewModel>();
        }
    }
}
