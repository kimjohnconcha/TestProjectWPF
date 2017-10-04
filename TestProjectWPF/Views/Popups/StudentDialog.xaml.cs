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

namespace TestProjectWPF.Views.Popups
{
    /// <summary>
    /// Interaction logic for StudentDialog.xaml
    /// </summary>
    public partial class StudentDialog : Window
    {
        public StudentDialog()
        {
            InitializeComponent();
        }

        private void cabcelbtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void sacebtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
