using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectWPF.ViewModels
{
    public class MainDashBoardVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public void GotoStudent()
        {
            System.Diagnostics.Debug.WriteLine("stud");
        }

        public void GotoInstructor()
        {
            System.Diagnostics.Debug.WriteLine("ins");
        }

        public void GotoStudentClassCard()
        {
            System.Diagnostics.Debug.WriteLine("card");
        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
