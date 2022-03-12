using DaminLibrary.MVVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Originer.Client.Common.Helper
{
    public class SnackBarHelper : MVVMBase
    {
        private string snackbarText;
        public string SnackbarText
        {
            get => snackbarText;
            set
            {
                snackbarText = value;
                OnPropertyChanged("SnackbarText");
            }
        }
        private bool isSnackbarActive;
        public bool IsSnackbarActive 
        {
            get => isSnackbarActive;
            set 
            {
                isSnackbarActive = value;
                OnPropertyChanged("IsSnackbarActive");
            }
        }
        public void SnackbarActive(string content)
        {
            SnackbarActive(content, 3000);
        }
        public void SnackbarActive(string content, int time)
        {
            IsSnackbarActive = true;
            this.SnackbarText = content;

            Task task = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(time);
                IsSnackbarActive = false;
            });

        }
        public void Start()
        {
            IsSnackbarActive = true;
        }
        public void SetContent(string content)
        {
            SnackbarText = content;
        }
        public void AutoActionDatContent(string content)
        {
            new Task(() =>
            {
                for (int i = 0; ; i++)
                {
                    if (IsSnackbarActive == false) break;
                    int datCount = i % 3;
                    string newMessage = content;
                    for (int x = 0; x < datCount; x++)
                    {
                        newMessage += ".";
                    }
                    this.SetContent(newMessage);
                    Thread.Sleep(500);
                    if (IsSnackbarActive == false) break;
                }
            }).Start();
        }
        public void Stop()
        {
            IsSnackbarActive = false;
        }
    }
}
