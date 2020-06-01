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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for EditWorker.xaml
    /// </summary>
    public partial class EditWorker : Window
    {
        public EditWorker()
        {
            InitializeComponent();
            EmployeeTypeComboBox.ItemsSource = db.employee.ToList();
            EmployeeTypeComboBox.DisplayMemberPath = "name";
        }

        private void EditWorkerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EmployeeTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void EditWorkerButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EmployeeTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
