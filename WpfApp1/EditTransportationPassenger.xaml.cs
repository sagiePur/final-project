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
    /// Interaction logic for EditTransportationPassenger.xaml
    /// </summary>
    public partial class EditTransportationPassenger : Window
    {
        dbEntities2 db = new dbEntities2();

        transportation_passangers t;

        public EditTransportationPassenger(transportation_passangers o)
        {
            InitializeComponent();

            TransportationComboBox.ItemsSource = db.transportation.ToList();
            TransportationComboBox.DisplayMemberPath = "Id";
            PassengerComboBox.ItemsSource = db.passenger.ToList();
            PassengerComboBox.DisplayMemberPath = "last_name";

            t = o;

            TransportationComboBox.SelectedValue = db.transportation.ToList().First(d => d.Id == t.transportation_id);
            PassengerComboBox.SelectedValue = db.passenger.ToList().First(d => d.Id == t.passenger_id);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            transportation transportation = (transportation)TransportationComboBox.SelectedItem;
            passenger passenger = (passenger)PassengerComboBox.SelectedItem;

            t.transportation_id = transportation.Id;
            t.passenger_id = passenger.Id;

            db.transportation_passangers.AddOrUpdate(t);

            db.SaveChanges();

            this.Close();
        }
    }
}
