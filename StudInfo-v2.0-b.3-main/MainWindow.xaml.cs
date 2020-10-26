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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StudInfo_v2._0_b._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void Add_Student(object sender, RoutedEventArgs e)
        {
            Adding_Student_Window adding_Student_Window = new Adding_Student_Window();
            adding_Student_Window.Show();
        }
        

        private void Open_Diary(object sender, RoutedEventArgs e)
        {
            Diary diary_windows = new Diary();
            diary_windows.Show();
        }

       

        private void Edit_Student(object sender, RoutedEventArgs e)
        {
            Edit_Student_Window edit_Student_Window = new Edit_Student_Window();
            edit_Student_Window.Show();
        }

        private void Edit_Theme(object sender, RoutedEventArgs e)
        {
            Theme_Editor edit_Theme_Window = new Theme_Editor();
            edit_Theme_Window.Show();
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("StudInfo v2.0 b.4 \nРазработано ЮС-4/10 \nЭто всего лишь конец начала...", "О StudInfo", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
