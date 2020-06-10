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
    }
}
