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
    /// Interaction logic for AddTransportationPassenger.xaml
    /// </summary>
    public partial class AddTransportationPassenger : Window
    {
        dbEntities2 db = new dbEntities2();

        public AddTransportationPassenger()
        {
            InitializeComponent();

            TransportationComboBox.ItemsSource = db.transportation.ToList();
            TransportationComboBox.DisplayMemberPath = "Id";
            PassengerComboBox.ItemsSource = db.passenger.ToList();
            PassengerComboBox.DisplayMemberPath = "last_name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            transportation transportation = (transportation)TransportationComboBox.SelectedItem;
            passenger passenger = (passenger)PassengerComboBox.SelectedItem;

            transportation_passangers o = new transportation_passangers();
            o.transportation_id = transportation.Id;
            o.passenger_id = passenger.Id;

            db.transportation_passangers.Add(o);

            db.SaveChanges();

            this.Close();
        }
    }
}
