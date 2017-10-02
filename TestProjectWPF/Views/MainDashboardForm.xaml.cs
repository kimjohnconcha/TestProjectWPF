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
        public MainDashboardForm()
        {
            InitializeComponent();
            this.DataContext = new MainDashBoardVM();
        }

        private void stud_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ins_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sc_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
