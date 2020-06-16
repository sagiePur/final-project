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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        dbEntities2 db = new dbEntities2();
        public MainWindow()
        {
            InitializeComponent();

            UpdateWorkerDataGrid();
            UpdateWorkerTypesDataGrid();
            UpdateCustomerDataGrid();
            UpdatePassengerDataGrid();
            UpdateVehicleDataGrid();
            UpdateExpenseDataGrid();
            UpdateVehicleAssignDataGrid();
            UpdateTransportationDataGrid();
            UpdateTransportationPassengersDataGrid();
        }

        private void UpdateWorkerDataGrid()
        {
            WorkersDataGrid.ItemsSource = db.employee.ToList();
        }

        private void UpdateWorkerTypesDataGrid()
        {
            WorkerTypesDataGrid.ItemsSource = db.employee_type.ToList();
        }

        private void UpdateCustomerDataGrid()
        {
            CustomerDataGrid.ItemsSource = db.customer.ToList();
        }

        private void UpdatePassengerDataGrid()
        {
            PassengerDataGrid.ItemsSource = db.passenger.ToList();
        }

        private void UpdateVehicleDataGrid()
        {
            VehicleDataGrid.ItemsSource = db.vehicle.ToList();
        }

        private void UpdateExpenseDataGrid()
        {
            ExpenseDataGrid.ItemsSource = db.expense.ToList();
        }

        private void UpdateVehicleAssignDataGrid()
        {
            VehicleAssignDataGrid.ItemsSource = db.vehicle_assign.ToList();
        }

        private void UpdateTransportationDataGrid()
        {
            TransportationDataGrid.ItemsSource = db.transportation.ToList();
        }

        private void UpdateTransportationPassengersDataGrid()
        {
            TransportationPassengerDataGrid.ItemsSource = db.transportation_passangers.ToList();
        }

        private void AddWorker_Click(object sender, RoutedEventArgs e)
        {
            AddWorker window = new AddWorker();
            Hide();
            window.ShowDialog();
            Show();
            UpdateWorkerDataGrid();
        }

        private void EditWorker_Click(object sender, RoutedEventArgs e)
        {
            EditWorker window = new EditWorker((employee)WorkersDataGrid.SelectedItem);
            Hide();
            window.ShowDialog();
            Show();
            UpdateWorkerDataGrid();
        }

        private void AddWorkerType_Click(object sender, RoutedEventArgs e)
        {
            AddWorkerType window = new AddWorkerType();
            Hide();
            window.ShowDialog();
            Show();
            UpdateWorkerTypesDataGrid();
        }

        private void EditWorkerType_Click(object sender, RoutedEventArgs e)
        {
            EditWorkerType window = new EditWorkerType((employee_type)WorkerTypesDataGrid.SelectedItem);
            Hide();
            window.ShowDialog();
            Show();
            UpdateWorkerTypesDataGrid();
        }

        private void DeleteWorkerType_Click(object sender, RoutedEventArgs e)
        {
            db.employee_type.Remove((employee_type)WorkerTypesDataGrid.SelectedItem);
            db.SaveChanges();
            UpdateWorkerTypesDataGrid();
        }

        private void DeleteWorker_Click(object sender, RoutedEventArgs e)
        {
            db.employee.Remove((employee)WorkersDataGrid.SelectedItem);
            db.SaveChanges();
            UpdateWorkerDataGrid();
        }

        private void AddCustomer_Click(object sender, RoutedEventArgs e)
        {
          AddCustomer window = new AddCustomer();
            Hide();
            window.ShowDialog();
            Show();
            UpdateCustomerDataGrid();
        }

        private void EditCustomer_Click(object sender, RoutedEventArgs e)
        {
            EditCustomer window = new EditCustomer((customer)CustomerDataGrid.SelectedItem);
            Hide();
            window.ShowDialog();
            Show();
            UpdateCustomerDataGrid();
        }

        private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            db.customer.Remove((customer)CustomerDataGrid.SelectedItem);
            db.SaveChanges();
            UpdateCustomerDataGrid();
        }

        private void AddPassenger_Click(object sender, RoutedEventArgs e)
        {
           AddPassenger window = new AddPassenger();
            Hide();
            window.ShowDialog();
            Show();
            UpdatePassengerDataGrid();
        }

        private void EditPassenger_Click(object sender, RoutedEventArgs e)
        {
            EditPassenger window = new EditPassenger((passenger)PassengerDataGrid.SelectedItem);
            Hide();
            window.ShowDialog();
            Show();
            UpdatePassengerDataGrid();
        }

        private void DeletePassenger_Click(object sender, RoutedEventArgs e)
        {
            db.passenger.Remove((passenger)PassengerDataGrid.SelectedItem);
            db.SaveChanges();
            UpdatePassengerDataGrid();
        }

        private void AddVehicle_Click(object sender, RoutedEventArgs e)
        {
            AddVehicle window = new AddVehicle();
            Hide();
            window.ShowDialog();
            Show();
            UpdateVehicleDataGrid();
        }

        private void EditVehicle_Click(object sender, RoutedEventArgs e)
        {
            EditVehicle window = new EditVehicle((vehicle)VehicleDataGrid.SelectedItem);
            Hide();
            window.ShowDialog();
            Show();
            UpdateVehicleDataGrid();
        }

        private void DeleteVehicle_Click(object sender, RoutedEventArgs e)
        {
            db.vehicle.Remove((vehicle)VehicleDataGrid.SelectedItem);
            db.SaveChanges();
            UpdateVehicleDataGrid();
        }

        private void AddExpense_Click(object sender, RoutedEventArgs e)
        {
            AddExpense window = new AddExpense();
            Hide();
            window.ShowDialog();
            Show();
            UpdateExpenseDataGrid();
        }

        private void EditExpense_Click(object sender, RoutedEventArgs e)
        {
            expense s = (expense)ExpenseDataGrid.SelectedItem;
            if (s == null)
                return;
            EditExpense window = new EditExpense(s);
            Hide();
            window.ShowDialog();
            Show();
            UpdateExpenseDataGrid();
        }

        private void DeleteExpense_Click(object sender, RoutedEventArgs e)
        {
            db.expense.Remove((expense)ExpenseDataGrid.SelectedItem);
            db.SaveChanges();
            UpdateExpenseDataGrid();
        }

        private void AddVehicleAssign_Click(object sender, RoutedEventArgs e)
        {
            AddVehicleAssign window = new AddVehicleAssign();
            Hide();
            window.ShowDialog();
            Show();
            UpdateVehicleAssignDataGrid();
        }

        private void EditVehicleAssign_Click(object sender, RoutedEventArgs e)
        {
            vehicle_assign s = (vehicle_assign)VehicleAssignDataGrid.SelectedItem;
            if (s == null)
                return;
            EditVehicleAssign window = new EditVehicleAssign(s);
            Hide();
            window.ShowDialog();
            Show();
            UpdateVehicleAssignDataGrid();
        }

        private void DeleteVehicleAssign_Click(object sender, RoutedEventArgs e)
        {
            db.vehicle_assign.Remove((vehicle_assign)VehicleAssignDataGrid.SelectedItem);
            db.SaveChanges();
            UpdateVehicleAssignDataGrid();
        }

        private void AddTransportation_Click(object sender, RoutedEventArgs e)
        {
            AddTransportation window = new AddTransportation();
            Hide();
            window.ShowDialog();
            Show();
            UpdateTransportationDataGrid();
        }

        private void EditTransportation_Click(object sender, RoutedEventArgs e)
        {
            transportation s = (transportation)TransportationDataGrid.SelectedItem;
            if (s == null)
                return;
            EditTransportation window = new EditTransportation(s);
            Hide();
            window.ShowDialog();
            Show();
            UpdateTransportationDataGrid();
        }

        private void DeleteTransportation_Click(object sender, RoutedEventArgs e)
        {
            db.transportation.Remove((transportation)TransportationDataGrid.SelectedItem);
            db.SaveChanges();
            UpdateTransportationDataGrid();
        }

        private void AddTransportationPassenger_Click(object sender, RoutedEventArgs e)
        {
            AddTransportationPassenger window = new AddTransportationPassenger();
            Hide();
            window.ShowDialog();
            Show();
            UpdateTransportationPassengersDataGrid();
        }

        private void EditTransportatioPassengern_Click(object sender, RoutedEventArgs e)
        {
            transportation_passangers s = (transportation_passangers)TransportationPassengerDataGrid.SelectedItem;
            if (s == null)
                return;
            EditTransportationPassenger window = new EditTransportationPassenger(s);
            Hide();
            window.ShowDialog();
            Show();
            UpdateTransportationPassengersDataGrid();
        }

        private void DeleteTransportationPassenger_Click(object sender, RoutedEventArgs e)
        {
            db.transportation_passangers.Remove((transportation_passangers)TransportationPassengerDataGrid.SelectedItem);
            db.SaveChanges();
            UpdateTransportationPassengersDataGrid();
        }
    }
}
