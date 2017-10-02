using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using TestProjectWPF.ViewModels;

namespace TestProjectWPF.Views
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        LoginVM loginvm = new LoginVM();

        public LoginForm()
        {
            InitializeComponent();
            this.DataContext = loginvm;
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {
            loginvm.Login();
        }
    }
}
