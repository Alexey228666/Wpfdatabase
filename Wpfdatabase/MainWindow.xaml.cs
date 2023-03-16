using System;
using System.Collections.Generic;
using System.Data;
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
using WpfApp1.Lab1DataSetTableAdapters;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PersonDepartmentTableAdapter person = new PersonDepartmentTableAdapter();
        DepartmentTableAdapter department = new DepartmentTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            PersonDataGrid.ItemsSource = person.GetData();
            DepartmentComboBox.ItemsSource = department.GetData();
            DepartmentComboBox.DisplayMemberPath = "Title";
        }

        private void DepartmentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show((DepartmentComboBox.SelectedItem as DataRowView).Row[1].ToString());
        }
    }
}
