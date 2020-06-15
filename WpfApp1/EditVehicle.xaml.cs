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
    /// Interaction logic for AddVehicle.xaml
    /// </summary>
    public partial class EditVehicle : Window
    {
        dbEntities2 db = new dbEntities2();

        vehicle v;

        public EditVehicle(vehicle o)
        {
            InitializeComponent();

            v = o;

            CarModelTextBox.Text = v.car_model;
            SitsTextBox.Text = v.sits.ToString();
            CarNumberTextBox.Text = v.car_number;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cModel = CarModelTextBox.Text;
            int sits = int.Parse(SitsTextBox.Text);
            string cNumber = CarNumberTextBox.Text;

            v.car_model = cModel;
            v.sits = sits;
            v.car_number = cNumber;

            db.vehicle.AddOrUpdate(v);

            db.SaveChanges();

            this.Close();

        }

       
    }
}
