using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TestProjectWPF.Views;

namespace TestProjectWPF.ViewModels
{
    public class MainDashBoardVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        public void GotoStudent()
        {
            var studWin = new StudentWindow();
            studWin.Show();
            studWin.Topmost = true;
        }

        public void GotoInstructor()
        {
            var insWin = new InstructorWindow();
            insWin.Show();
            insWin.Topmost = true;
        }

        public void GotoStudentClassCard()
        {
            var sclassWin = new StudentClassCardWindow();
            sclassWin.Show();
            sclassWin.Topmost = true;
        }


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
