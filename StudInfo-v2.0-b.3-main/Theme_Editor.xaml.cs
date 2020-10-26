using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
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
    /// Логика взаимодействия для Theme_Editor.xaml
    /// </summary>
    public partial class Theme_Editor : Window
    {
        string Theme_Add, Date_Add, Zadanie_Add;
        public Theme_Editor()
        {
            InitializeComponent();
            StudentDBEntities db = new StudentDBEntities();
            this.dataTheme.ItemsSource = db.ThemeDBs.ToList();
        }
        private int updatingDnevnikID = 0;

        private void dataTheme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.dataTheme.SelectedIndex >= 0)
            {
                if (this.dataTheme.SelectedItems.Count >= 0)
                {
                    if (this.dataTheme.SelectedItems[0].GetType() == typeof(ThemeDB))
                    {
                        ThemeDB Edit_S = (ThemeDB)this.dataTheme.SelectedItems[0];
                        Theme_Add_Box.Text = Edit_S.Theme;
                        Data_Picker.Text = Edit_S.Data;
                        Zadanie_Add_Box.Text = Edit_S.Zadanie;
                        updatingDnevnikID = Edit_S.Id;
                    }
                }
            }

        }
        private void Load_Theme()
        {
            StudentDBEntities db = new StudentDBEntities();
            this.dataTheme.ItemsSource = db.ThemeDBs.ToList();
        }
        private void Add_Theme_Click(object sender, RoutedEventArgs e)
        {
            Theme_Add = Theme_Add_Box.Text.ToString();
            Zadanie_Add = Zadanie_Add_Box.Text.ToString();
            DateTime? TH_Date = Data_Picker.SelectedDate;
            if(Theme_Add == null || Zadanie_Add == null || TH_Date == null)
            {
                MessageBox.Show("Введено пустое поле\nПовторите ввод!", "StudInfo v2.0 b.3", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                Date_Add = TH_Date.Value.ToShortDateString();
                Add_T();
                Load_Theme();
            }
        }
        private void Add_T()
        {
            StudentDBEntities db = new StudentDBEntities();
            ThemeDB dnevnik = new ThemeDB()
            {
                Theme = Theme_Add,
                Data = Date_Add,
                Zadanie = Zadanie_Add
            };
            db.ThemeDBs.Add(dnevnik);
            db.SaveChanges();
        }

        private void Delete_Theme_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Save_Change_Theme_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Cancel_Adding(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
