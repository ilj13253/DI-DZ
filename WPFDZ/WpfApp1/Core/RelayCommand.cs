using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp1.Core
{
    public class RelayCommand(Action<object>execute,Func<object?,bool>?canExecute=null) : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove{ CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter=null)=>
            canExecute == null || canExecute(parameter=null);


        public void Execute(object? parameter=null)=>
            execute(parameter);
    }
}
