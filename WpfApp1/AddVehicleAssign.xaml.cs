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
    /// Interaction logic for AddVehicleAssign.xaml
    /// </summary>
    public partial class AddVehicleAssign : Window
    {
        dbEntities2 db = new dbEntities2();

        public AddVehicleAssign()
        {
            InitializeComponent();

            VehicleComboBox.ItemsSource = db.vehicle.ToList();
            VehicleComboBox.DisplayMemberPath = "car_number";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            vehicle v = (vehicle)VehicleComboBox.SelectedItem;
            DateTime startDate = (DateTime)StartDate.Value;
            DateTime endDate = (DateTime)EndDate.Value;

            vehicle_assign o = new vehicle_assign();
            o.vehicle_id = v.id;
            o.beginning_time = startDate;
            o.end_time = endDate;

            db.vehicle_assign.Add(o);

            db.SaveChanges();

            this.Close();
        }
    }
}
