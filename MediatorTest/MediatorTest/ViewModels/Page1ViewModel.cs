using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MediatorTest.ViewModels
{
    public class Page1ViewModel
    {
        public Page1ViewModel()
        {
            //어디서나 사용할 수 있는 함수로 등록
            Utils.Mediator.Register("Page1ViewModel.AddNumbers", AddNumbers);
        }

        public void AddNumbers(object obj)
        {
            int sum = 0;
            object[] objParams = (object[])obj;
            foreach (object o in objParams)
                sum += (int)o;

            MessageBox.Show("합계 AddNumbers의 결과는 " + sum.ToString() + " 입니다.");
        }
    }
}
