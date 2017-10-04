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
    /// Interaction logic for StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        StudentVM studVM = new StudentVM();

        public StudentWindow()
        {
            InitializeComponent();
            this.DataContext = studVM;
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this record?", 
                "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var student = studDataGrid.SelectedIndex;
                studVM.OnDelete(student);
            }
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Topmost = false;
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            studVM.OnAdd();
        }
    }
}
