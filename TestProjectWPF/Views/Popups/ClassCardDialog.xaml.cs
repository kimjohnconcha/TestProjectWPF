using System;
using System.Windows;
using TestProjectWPF.Data;
using TestProjectWPF.Models;

namespace TestProjectWPF.Views.Popups
{
    /// <summary>
    /// Interaction logic for ClassCardDialog.xaml
    /// </summary>
    public partial class ClassCardDialog : Window
    {
        public ClassCardDialog()
        {
            InitializeComponent();;

            // populate items
            student.ItemsSource = StudentDataItems.Instance.StudentList;
            faculty.ItemsSource = InstructorDataItems.Instance.InstructorList;
        }

        private void cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Check if ID already exist
                foreach (var item in StudentDataItems.Instance.StudentList)
                {
                    if (item.ID == Convert.ToInt32(ID.Text))
                    {
                        MessageBox.Show("Class card ID already exist!", "Save Error!");
                    }
                }

                // add new Class Card

                Student _student = new Student();
                Instructor _faculty = new Instructor();

                // Test queries
                foreach (var item in StudentDataItems.Instance.StudentList)
                {
                    if(item.ToString() == student.Text)
                    {
                        _student = item;
                        break;
                    }
                }

                foreach (var item in InstructorDataItems.Instance.InstructorList)
                {
                    if (item.ToString() == faculty.Text)
                    {
                        _faculty = item;
                        break;
                    }
                }

                // create obj
                var _classCard = new StudentClassCard()
                {
                    ID = Convert.ToInt32(ID.Text),
                    student = _student,
                    instructor = _faculty,
                    Status = status.Text
                };

                //Save class card
                App.Datamanager.SaveClassCard(_classCard);

                this.Close();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error saving Class card: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
