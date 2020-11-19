using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WPFCommandsDemo
{
    public class ViewModel
    {
        public ICommand MyCommand { get; set; }

        public ViewModel()
        {
            MyCommand = new Command(ExcuteMethod, CanExecuteMethod);
        }

        private bool CanExecuteMethod(object arg)
        {
            return true;
        }

        private void ExcuteMethod(object obj)
        {
            MessageBox.Show("코드비하인드가 아닌 Command ExecuteMethod");
        }
    }
}
