using GalaSoft.MvvmLight.Command;
using MaterialDesignThemes.Wpf;
using Originer.Client.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Originer.Client.Member.ViewModel
{
    public class TestViewModel
    {
        public ICommand TestButton { get; set; }
        public SnackBarHelper Snackbar { get; set; } = new SnackBarHelper();
        public TestViewModel()
        {
            TestButton = new RelayCommand(OnTest);
        }
        private void OnTest() 
        {
            Snackbar.SnackbarActive("계정정보를 확인해주세요.");
        }
    }
}
