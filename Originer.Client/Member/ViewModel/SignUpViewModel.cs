using DaminLibrary.Expansion;
using DaminLibrary.MVVM;
using GalaSoft.MvvmLight.Command;
using Originer.Client.Common.Damin;
using Originer.Client.Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Originer.Client.Member.ViewModel
{
    public class SignUpViewModel : SignUpInfo
    {
        //private void OnAccountStatusCheck(string account)
        //{
        //    if (account.IsNullOrWhiteSpace() || account.Length == 0) { AccountCheckButtonIsEnabled = false; AccountStatus = "아이디를 입력해주세요."; AccountStatusForeground = Brushes.Red; return; }
        //    else if ((account.Length > 0 && account.Length < 4) || account.Length > 16) { AccountCheckButtonIsEnabled = true; AccountStatus = "아이디는 4~16 글자 가능합니다."; AccountStatusForeground = Brushes.Red; return; }
        //    else if (account.Length > 4 || account.Length < 16) { AccountCheckButtonIsEnabled = true; AccountStatus = "중복확인이 필요합니다"; AccountStatusForeground = Brushes.Green; return; }
        //}
        #region Account
        private string accountTextBox;
        public string AccountTextBox
        {
            get => accountTextBox;
            set
            {
                accountTextBox = value;
                //OnAccountStatusCheck(AccountTextBox);
                OnPropertyChanged("AccountTextBox");
            }
        }

        private bool accountTextBoxIsEnabled = true;
        public bool AccountTextBoxIsEnabled
        {
            get => accountTextBoxIsEnabled;
            set
            {
                accountTextBoxIsEnabled = value;
                OnPropertyChanged("AccountTextBoxIsEnabled");
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
        private string accountStatus = "아이디를 입력해주세요.";
        public string AccountStatus
        {
            get => accountStatus;
            set
            {
                accountStatus = value;
                OnPropertyChanged("AccountStatus");
            }
        }
        private Brush accountStatusForeground = Brushes.Red;
        public Brush AccountStatusForeground
        {
            get => accountStatusForeground;
            set
            {
                accountStatusForeground = value;
                OnPropertyChanged("AccountStatusForeground");
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

        public SnackBarHelper Snackbar { get; set; } = new SnackBarHelper();


        public SignUpViewModel()
        {
            AccountCheckButton = new RelayCommand(OnAccountCheck);
            SendCodeButton = new RelayCommand(OnSendCode);
        }
        private void OnAccountCheck()
        {
            if (AccountTextBox == "abc") { Snackbar.SnackbarActive("중복된 아이디가 있습니다"); return; } // DB 중복 처리 해줘야함

            if (MessageBox.Show("사용 가능한 아이디 입니다. 사용 하시겠습니까? ", "Yes-No", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                // Yes 선택시 이벤트 처리
                Console.WriteLine("Yes");
                AccountTextBoxIsEnabled = false;
                AccountCheckButtonIsEnabled = false;
            }
            else
            {
                // No 선택시 이벤트 처리
                Console.WriteLine("NO");
            }
        }
        private void OnSendCode()
        {
            Snackbar.SnackbarActive("테스트테스트");
            Console.WriteLine("OnSendCode Click");
        }
        public override string DataErrorInfo(string columnName)
        {

            return base.DataErrorInfo(columnName);
        }


    }
}
