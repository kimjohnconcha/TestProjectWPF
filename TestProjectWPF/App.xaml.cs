﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TestProjectWPF.Data;
using TestProjectWPF.Helpers;
using TestProjectWPF.Models;

namespace TestProjectWPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static DataManager datamanager { get; private set; }

        public App()
        {
            StudentDataItems.Instance.StudentList = new ObservableCollection<Student>();
            InstructorDataItems.Instance.InstructorList = new ObservableCollection<Instructor>();
            StudentClassCardDataItems.Instance.StudentClassCardList = new ObservableCollection<StudentClassCard>();
            SetInitialData();
            datamanager = new DataManager(new DataHelper());
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            System.Diagnostics.Debug.WriteLine("Welcome!!");
        }

        private void SetInitialData()
        {
            AppTestData.SetStudentData();
            AppTestData.SetInstructorData();
            AppTestData.SetStudentClassCardData();
        }
    }
}
