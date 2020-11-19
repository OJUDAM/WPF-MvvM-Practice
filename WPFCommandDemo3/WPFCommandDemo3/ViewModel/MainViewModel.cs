using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFCommandDemo3.ViewModel.Command;

namespace WPFCommandDemo3.ViewModel
{
    public class MainViewModel
    {
        public ObservableCollection<string> MyMessages { get; private set; }

        public DelegateCommand MessageBoxCommand { get; private set; }
        public DelegateCommand ConsoleCommand { get; private set; }

        public MainViewModel()
        {
            MyMessages = new ObservableCollection<string>()
            {
                "안녕하세요!",
                "제 이름은 Djam 입니다.",
                "메시지 박스",
                "콘솔"
            };

            MessageBoxCommand =
                new DelegateCommand(DisplayInMessageBox, MessageBoxCanUse);
            ConsoleCommand =
                new DelegateCommand(DisplayInConsole, ConsoleCanUse);
        }

        public void DisplayInMessageBox(object message)
        {
            MessageBox.Show((string)message);
        }
        public void DisplayInConsole(object message)
        {
            Console.WriteLine((string)message);
        }

        public bool MessageBoxCanUse(object message)
        {
            if ((string)message == "콘솔")
                return false;

            return true;
        }
        public bool ConsoleCanUse(object message)
        {
            if ((string)message == "메시지 박스")
                return false;

            return true;
        }
    }
}
