using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestProjectWPF.Data;
using TestProjectWPF.Models;
using TestProjectWPF.Views.Popups;

namespace TestProjectWPF.ViewModels
{
    public class StudentVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Student> _studList;
        public ObservableCollection<Student> StudList
        {
            get { return _studList; }
            set { _studList = value; OnPropertyChanged("StudList"); }
        }


        public StudentVM()
        {
            StudList = StudentDataItems.Instance.StudentList;
        }

        public void OnAdd()
        {
            var studDialog = new StudentDialog();
            studDialog.Show();
            studDialog.Topmost = true;
        }

        public void OnDelete(int std_index)
        {
            StudentDataItems.Instance.StudentList.RemoveAt(std_index);
        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
