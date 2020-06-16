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
    /// Interaction logic for AddTransportation.xaml
    /// </summary>
    public partial class EditTransportation : Window
    {
        dbEntities2 db = new dbEntities2();

        transportation t = new transportation();

        public EditTransportation(transportation o)
        {
            InitializeComponent();

            VehicleAssignComboBox.ItemsSource = db.vehicle_assign.ToList();
            VehicleAssignComboBox.DisplayMemberPath = "vehicle.car_number";
            EmployeeComboBox.ItemsSource = db.employee.ToList();
            EmployeeComboBox.DisplayMemberPath = "name";
            CustomerComboBox.ItemsSource = db.customer.ToList();
            CustomerComboBox.DisplayMemberPath = "last_name";

            t = o;

            VehicleAssignComboBox.SelectedValue = db.vehicle_assign.ToList().First(d => d.Id == t.vehicle_assign_id);
            EmployeeComboBox.SelectedValue = db.employee.ToList().First(d => d.Id == t.employee_id);
            CustomerComboBox.SelectedValue = db.customer.ToList().First(d => d.Id == t.customer_id);
            IncomeTextBox.Text = t.income.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs ex)
        {
            vehicle_assign vehicle_assign = (vehicle_assign)VehicleAssignComboBox.SelectedItem;
            employee employee = (employee)EmployeeComboBox.SelectedItem;
            customer customer = (customer)CustomerComboBox.SelectedItem;
            float income = float.Parse(IncomeTextBox.Text);

            t.vehicle_assign_id = vehicle_assign.Id;
            t.employee_id = employee.Id;
            t.customer_id = customer.Id;
            t.income = income;

            db.transportation.AddOrUpdate(t);

            db.SaveChanges();

            this.Close();
        }
    }
}
