using DaminLibrary.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Originer.Client.Common.Damin
{
    public class SignUpInfo : MVVMBase, IDataErrorInfo
    {
        public string Account { get; set; }

        public virtual string this[string columnName]
        {
            get => null;
        }

        public string Error
        {
            get => null;
        }
        public virtual string DataErrorInfo(string columnName) 
        {
            return null;
        }
       

    }
}
