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
    /// Interaction logic for AddVehicleAssign.xaml
    /// </summary>
    public partial class EditVehicleAssign : Window
    {
        dbEntities2 db = new dbEntities2();

        vehicle_assign v;

        public EditVehicleAssign(vehicle_assign o)
        {
            InitializeComponent();

            VehicleComboBox.ItemsSource = db.vehicle.ToList();
            VehicleComboBox.DisplayMemberPath = "car_number";

            v = o;

            VehicleComboBox.SelectedValue = db.vehicle.ToList().First(d => d.id == v.vehicle_id);
            StartDate.Value = v.beginning_time;
            EndDate.Value = v.end_time;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vehicle vehicle = (vehicle)VehicleComboBox.SelectedItem;
            DateTime startDate = (DateTime)StartDate.Value;
            DateTime endDate = (DateTime)EndDate.Value;

            v.vehicle_id = vehicle.id;
            v.beginning_time = startDate;
            v.end_time = endDate;

            db.vehicle_assign.AddOrUpdate(v);

            db.SaveChanges();

            this.Close();
        }
    }
}
