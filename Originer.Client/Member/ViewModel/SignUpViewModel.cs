using DaminLibrary.MVVM;
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
    public class SignUpViewModel : MVVMBase
    {
        #region Account
        private string accountTextBox;
        public string AccountTextBox 
        {
            get => accountTextBox;
            set
            {
                accountTextBox = value;
                if (AccountTextBox is null || AccountTextBox == "") { AccountCheckButtonIsEnabled = false; }
                else { AccountCheckButtonIsEnabled = true; }
                OnPropertyChanged("AccountTextBox");
                Test();
            }
        }
        public ICommand AccountCheckButton { get; set; }
        private bool accountCheckButtonIsEnabled;
        public bool AccountCheckButtonIsEnabled 
        {
            get => accountCheckButtonIsEnabled;
            set 
            {
                accountCheckButtonIsEnabled = value;
                OnPropertyChanged("AccountCheckButtonIsEnabled");
            }
        }
        #endregion
        #region Password
        public string Password { get; set; }
        public string PasswordCheck { get; set; }
        #endregion
        #region Mail
        private Visibility gridVisibility = Visibility.Collapsed;
        public Visibility GridVisibility 
        {
            get => gridVisibility;
            set 
            {
                gridVisibility = value;
                OnPropertyChanged("GridVisibility");
            }
        }
        private string mailTextBox;
        public string MailTextBox 
        {
            get => mailTextBox;
            set 
            {
                mailTextBox = value;
                OnPropertyChanged("MailTextBox");
            }
        }
        private ICommand sendCodeButton;
        public ICommand SendCodeButton 
        {
            get => sendCodeButton;
            set 
            {
                sendCodeButton = value;
                OnPropertyChanged("SendCodeButton");
            }
        }
        private string mailCodeTextBox;
        public string MailCodeTextBox 
        {
            get => mailCodeTextBox;
            set 
            {
                mailCodeTextBox = value;
                OnPropertyChanged("MailCodeTextBox");
            }
        }
        private ICommand mailCodeCheckButton;
        public ICommand MailCodeCheckButton 
        {
            get => mailCodeCheckButton;
            set 
            {
                mailCodeCheckButton = value;
                OnPropertyChanged("MailCodeCheckButton");
            }
        }
        public bool MailCodeCheckButtonIsEnabled { get; set; } = true;
        #endregion



        private bool signUpButtonIsEnabled = true;
        public bool SignUpButtonIsEnabled
        {
            get => signUpButtonIsEnabled;
            set
            {
                signUpButtonIsEnabled = value;
                OnPropertyChanged("SignUpButtonIsEnabled");
            }
        }
        public SignUpViewModel()
        {
            SendCodeButton = new RelayCommand(OnSendCode);
        }
        private void OnSendCode() 
        {
            Console.WriteLine("OnSendCode Click");
        }
    }
}
