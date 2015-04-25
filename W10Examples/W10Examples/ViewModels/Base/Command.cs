using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace W10Examples.ViewModels.Base
{
    //Implement by your requierements (Actions, Func...)
    public class Command<T> : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {

        }

        public Command(Action<T> a)
        {

        }
    }
}
