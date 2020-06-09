using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
        dbEntities2 db = new dbEntities2();

        employee e;

        public EditWorker(employee o)
        {
            InitializeComponent();
            EmployeeTypeComboBox.ItemsSource = db.employee_type.ToList();
            EmployeeTypeComboBox.DisplayMemberPath = "title";

            e = o;

            NameTextBox.Text = e.name;
            TelephoneTextBox.Text = e.telephone;
            AddressTextBox.Text = e.address;
            LNTextBox.Text = e.license_number;
            EmployeeTypeComboBox.SelectedValue = db.employee_type.ToList().First(d => d.Id == e.employee_type_id);
        }

        private void EditWorkerButton_Click(object sender, RoutedEventArgs ea)
        {
            string name = NameTextBox.Text;
            string telephone = TelephoneTextBox.Text;
            string address = AddressTextBox.Text;
            string lN = LNTextBox.Text;
            int type = ((employee_type)EmployeeTypeComboBox.SelectedItem).Id;

            
            e.name = name;
            e.telephone = telephone;
            e.address = address;
            e.license_number = lN;
            e.employee_type_id = type;

            db.employee.AddOrUpdate(e);

            db.SaveChanges();

            this.Close();
        }
    }
}
