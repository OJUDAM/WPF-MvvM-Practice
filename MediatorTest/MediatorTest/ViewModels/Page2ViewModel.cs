﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MediatorTest.ViewModels
{
    public class Page2ViewModel
    {
        public Page2ViewModel()
        {
            //어디서나 사용할 수 있는 함수로 등록
            Utils.Mediator.Register("Page2ViewModel.Greeting", Greeting);
        }

        private void Greeting(object obj)
        {
            MessageBox.Show(obj.ToString() + " 님 안녕하세요.");
        }
        
    }
}
