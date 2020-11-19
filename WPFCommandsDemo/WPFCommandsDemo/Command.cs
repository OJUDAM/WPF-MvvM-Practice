using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFCommandsDemo
{
    public class Command : ICommand
    {
        Action<object> _excuteMethod;
        Func<object, bool> _canExcuteMethod;
        public event EventHandler CanExecuteChanged;

        public Command(Action<object> excuteMethod, Func<object, bool> canExecuteMethod)
        {
            this._excuteMethod = excuteMethod;
            this._canExcuteMethod = canExecuteMethod;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _excuteMethod(parameter);
        }
    }
}
