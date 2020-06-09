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
    /// Interaction logic for AddWorker.xaml
    /// </summary>
    public partial class AddWorker : Window
    {
        dbEntities2 db = new dbEntities2();
        public AddWorker()
        {
            InitializeComponent();
            EmployeeTypeComboBox.ItemsSource = db.employee_type.ToList();
            EmployeeTypeComboBox.DisplayMemberPath = "title";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AddWorkerButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string telephone = TelephoneTextBox.Text;
            string address = AddressTextBox.Text;
            string lN = LNTextBox.Text;
            int type = ((employee_type)EmployeeTypeComboBox.SelectedItem).Id;

            employee o = new employee(); //יצירת אובייקט עובד חדש
            o.name = name;
            o.telephone = telephone;
            o.address = address;
            o.license_number = lN;
            o.employee_type_id = type;

            db.employee.Add(o);

            db.SaveChanges();

            this.Close();
        }

        private void EmployeeTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
