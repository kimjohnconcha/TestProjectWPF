using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TestProjectWPF.Data;
using TestProjectWPF.Models;
using TestProjectWPF.Views.Popups;

namespace TestProjectWPF.ViewModels
{
    public class StudentClassCardVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<StudentClassCard> _cclist;
        public ObservableCollection<StudentClassCard> CCList
        {
            get { return _cclist; }
            set { _cclist = value; OnPropertyChanged("CCList"); }
        }

        public StudentClassCardVM()
        {
            CCList = StudentClassCardDataItems.Instance.StudentClassCardList;
        }

        public void OnAdd()
        {
            var ccDialog = new ClassCardDialog();
            ccDialog.Show();
            ccDialog.Topmost = true;
        }

        public void OnDelete(int std_index)
        {
            StudentClassCardDataItems.Instance.StudentClassCardList.RemoveAt(std_index);
        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
