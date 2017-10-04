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
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestProjectWPF.ViewModels;

namespace TestProjectWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainDashboardForm : Window
    {
        MainDashBoardVM maindashVM = new MainDashBoardVM();

        public MainDashboardForm()
        {
            InitializeComponent();
            
            this.DataContext = maindashVM;
        }

        private void stud_button_Click(object sender, RoutedEventArgs e)
        {
            maindashVM.GotoStudent();
        }

        private void ins_button_Click(object sender, RoutedEventArgs e)
        {
            maindashVM.GotoInstructor();
        }

        private void sc_button_Click(object sender, RoutedEventArgs e)
        {
            maindashVM.GotoStudentClassCard();
        }
    }
}
