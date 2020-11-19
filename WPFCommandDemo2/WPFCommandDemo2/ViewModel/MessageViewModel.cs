using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFCommandDemo2.ViewModel.Command;

namespace WPFCommandDemo2.ViewModel
{
    public class MessageViewModel
    {
        //public string MessageText { get; set; }
        public MessageCommand DisplayMessageCommand { get; private set; }

        public MessageViewModel()
        {
            DisplayMessageCommand = new MessageCommand(DisplayMessage);
        }

        public void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
