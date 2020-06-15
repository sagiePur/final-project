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
    /// Interaction logic for AddVehicle.xaml
    /// </summary>
    public partial class AddVehicle : Window
    {
        dbEntities2 db = new dbEntities2();

        public AddVehicle()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string cModel = CarModelTextBox.Text;
            int sits = int.Parse(SitsTextBox.Text);
            string cNumber = CarNumberTextBox.Text;

            vehicle o = new vehicle();
            o.car_model = cModel;
            o.sits = sits;
            o.car_number = cNumber;

            db.vehicle.Add(o);

            db.SaveChanges();

            this.Close();

        }
    }
}
