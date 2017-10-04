using System.Windows;
using TestProjectWPF.ViewModels;

namespace TestProjectWPF.Views
{
    /// <summary>
    /// Interaction logic for StudentClassCardWindow.xaml
    /// </summary>
    public partial class StudentClassCardWindow : Window
    {
        StudentClassCardVM ccVM = new StudentClassCardVM();

        public StudentClassCardWindow()
        {
            InitializeComponent();
            this.DataContext = ccVM;
        }

        private void delete_btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Are you sure you want to delete this record?", 
                "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var cc = studDataGrid.SelectedIndex;
                ccVM.OnDelete(cc);
            }
        }

        private void cancel_btn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Topmost = false;
        }

        private void add_btn_Click(object sender, RoutedEventArgs e)
        {
            ccVM.OnAdd();
        }
    }
}
