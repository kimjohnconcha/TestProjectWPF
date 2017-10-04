using System;
using System.Windows;
using TestProjectWPF.Data;
using TestProjectWPF.Models;

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
            try
            {
                foreach (var item in StudentDataItems.Instance.StudentList)
                {
                    if (item.ID == Convert.ToInt32(studid.Text))
                    {
                        MessageBox.Show("Student ID already exist!", "Save Error!");
                    }
                }

                // add new student
                StudentDataItems.Instance.StudentList.Add(new Student()
                {
                    ID = Convert.ToInt32(studid.Text),
                    Firstname = studfname.Text,
                    Lastname = studlname.Text,
                    StudentCode = studcode.Text,
                    course = studcourse.Text,
                    Room = studroom.Text
                });

                this.Close();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error saving student: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
