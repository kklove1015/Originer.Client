using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Originer.Client
{
    public static class Program
    {
        [STAThread]
        public static void Main() 
        {
            var resourceLocationUri = new Uri("/Originer.Client;component/app.xaml" , UriKind.Relative);
            System.Windows.Application.LoadComponent(resourceLocationUri); //app.xaml 진입점 location 변경
            System.Windows.Application.Current.ShutdownMode = System.Windows.ShutdownMode.OnExplicitShutdown; //셧다운 모드 설정

            var loginView = new Member.View.LoginView();
            bool? dialogResult = loginView.ShowDialog();

            if (dialogResult != true) { return; }
            var mainView = new Main.View.MainView();
            mainView.ShowDialog();
        }
    }
}
