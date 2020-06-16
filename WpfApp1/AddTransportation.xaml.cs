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
    /// Interaction logic for AddTransportation.xaml
    /// </summary>
    public partial class AddTransportation : Window
    {
        dbEntities2 db = new dbEntities2();

        public AddTransportation()
        {
            InitializeComponent();

            VehicleAssignComboBox.ItemsSource = db.vehicle_assign.ToList();
            VehicleAssignComboBox.DisplayMemberPath = "vehicle.car_number";
            EmployeeComboBox.ItemsSource = db.employee.ToList();
            EmployeeComboBox.DisplayMemberPath = "name";
            CustomerComboBox.ItemsSource = db.customer.ToList();
            CustomerComboBox.DisplayMemberPath = "last_name";
        }

        private void Button_Click(object sender, RoutedEventArgs ex)
        {
            vehicle_assign vehicle_assign = (vehicle_assign)VehicleAssignComboBox.SelectedItem;
            employee employee = (employee)EmployeeComboBox.SelectedItem;
            customer customer = (customer)CustomerComboBox.SelectedItem;
            float income = float.Parse(IncomeTextBox.Text);

            if ((employee.license_number == null || employee.employee_type.license_type == "D1") && vehicle_assign.vehicle.sits > 20)
            {
                if (employee.license_number == null)
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Please choose a driver!");
                } else
                {
                    Xceed.Wpf.Toolkit.MessageBox.Show("Please choose a D driver!");
                }

                return;
            }

            transportation o = new transportation();
            o.vehicle_assign_id = vehicle_assign.Id;
            o.employee_id = employee.Id;
            o.customer_id = customer.Id;
            o.income = income;

            db.transportation.Add(o);

            db.SaveChanges();

            this.Close();
        }
    }
}
