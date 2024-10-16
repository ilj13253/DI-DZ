using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Core;

namespace WpfApp1.Service.Interfaces
{
    public interface INavigateService
    {
        BaseViewModel CurrentViewModel { get; }
        void NavigateTo<TViewModel>()where TViewModel : BaseViewModel;
    }
}
