using DaminLibrary.Expansion;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Originer.Client.Member.ViewModel
{
    public class LoginViewModel
    {
        public Window NowWIndow { get; set; }
        public string AccountTextBox { get; set; }
        public string Password { get; set; }
        public ICommand LoginButton { get; set; }
        public ICommand SignUpButton { get; set; }

        public ICommand TestButton { get; set; }

        public LoginViewModel(Window window)
        {
            NowWIndow = window;
            LoginButton = new RelayCommand(OnLogin);
            SignUpButton = new RelayCommand(OnSignUp);

            TestButton = new RelayCommand(OnTest);
        }
        private void OnLogin() 
        {
            Console.WriteLine("On Login Button Click");
        }
        private void OnSignUp() 
        {
            var signUpView = new View.SignUpView();
            signUpView.ShowDialog();
        }
        private void OnTest() 
        {
            var testView = new View.TestView();
            testView.ShowDialog();
        }

    }
}
