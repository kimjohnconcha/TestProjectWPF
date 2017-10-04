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
    public class InstructorVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Instructor> _insList;
        public ObservableCollection<Instructor> InsList
        {
            get { return _insList; }
            set { _insList = value; OnPropertyChanged("InsList"); }
        }

        public InstructorVM()
        {
            InsList = InstructorDataItems.Instance.InstructorList;
        }

        public void OnAdd()
        {
            var insDialog = new InstructorDialog();
            insDialog.Show();
            insDialog.Topmost = true;
        }

        public void OnDelete(int ins_index)
        {
            InstructorDataItems.Instance.InstructorList.RemoveAt(ins_index);
        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
