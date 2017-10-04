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
    /// Interaction logic for InstructorWindow.xaml
    /// </summary>
    public partial class InstructorWindow : Window
    {
        InstructorVM insvm = new InstructorVM();

        public InstructorWindow()
        {
            InitializeComponent();
            this.DataContext = insvm;
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this record?", 
                "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var ins = insDataGrid.SelectedIndex;
                insvm.OnDelete(ins);
            }
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            insvm.OnAdd();
        }
    }
}
