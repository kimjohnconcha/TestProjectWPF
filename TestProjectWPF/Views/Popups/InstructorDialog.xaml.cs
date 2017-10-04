using System;
using System.Windows;
using TestProjectWPF.Data;
using TestProjectWPF.Models;

namespace TestProjectWPF.Views.Popups
{
    /// <summary>
    /// Interaction logic for StudentDialog.xaml
    /// </summary>
    public partial class InstructorDialog : Window
    {
        public InstructorDialog()
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
                foreach (var item in InstructorDataItems.Instance.InstructorList)
                {
                    if (item.ID == Convert.ToInt32(insid.Text))
                    {
                        MessageBox.Show("Instructor ID already exist!", "Save Error!");
                    }
                }

                // add new Instructor
                InstructorDataItems.Instance.InstructorList.Add(new Instructor()
                {
                    ID = Convert.ToInt32(insid.Text),
                    Firstname = insfname.Text,
                    Lastname = inslname.Text,
                    FacultyID = insfacid.Text,
                    Deparment = insdepartment.Text,
                    Subject = inssubject.Text
                });

                this.Close();
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Error saving instructor: " + ex.Message);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
