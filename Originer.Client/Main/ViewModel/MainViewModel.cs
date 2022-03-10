using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Originer.Client.Main.ViewModel
{
    public class MainViewModel
    {
        public ICommand TestButton { get; set; }
        public MainViewModel()
        {
            TestButton = new RelayCommand(OnTest);
        }
        private void OnTest() 
        {
            Console.WriteLine("Test Button Click");
        }

    }
}
