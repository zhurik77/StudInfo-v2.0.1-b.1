using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudInfo_v2._0_b._3
{
    /// <summary>
    /// Логика взаимодействия для Diary.xaml
    /// </summary>
    public partial class Diary : Window
    {
        private string FIO_Student, StudentGroup;
        private int StudentID;
        public Diary()
        {
            InitializeComponent();
            StudentDBEntities db = new StudentDBEntities();
            this.StudentDG.ItemsSource = db.Students.ToList();
            StudentDBEntities diaryDB = new StudentDBEntities();
            this.ThemeDG.ItemsSource = db.ThemeDBs.ToList();
        }



        private void ThemeDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private int updatingStudentID = 0;
        private void StudentDG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (this.StudentDG.SelectedIndex >= 0)
            {
                if (this.StudentDG.SelectedItems.Count >= 0)
                {
                    if (this.StudentDG.SelectedItems[0].GetType() == typeof(Student))
                    {
                        Student Edit_S = (Student)this.StudentDG.SelectedItems[0];
                        FIO_Student = Edit_S.S_Name;
                        textBoxStudent_FIO.Content = Edit_S.S_Name;
                        // Group_Student.Text = Edit_S.S_Group;
                        updatingStudentID = Edit_S.Id;
                        StudentID = Edit_S.Id;
                        textBox_GroupStudent.Content = Edit_S.S_Group;
                    }
                }
            }
        }

    }
}
