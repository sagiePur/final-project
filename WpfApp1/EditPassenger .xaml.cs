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
    /// Interaction logic for AddPassenger.xaml
    /// </summary>
    public partial class EditPassenger : Window
    {
        dbEntities2 db = new dbEntities2();

        passenger p;

        public EditPassenger(passenger o)
        {
            InitializeComponent();

            p = o;

            FirstNameTextBox.Text = p.first_name;
            LastNameTextBox.Text = p.last_name;
            PhoneTextBox.Text = p.phone;
            AddressTextBox.Text = p.address;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fName = FirstNameTextBox.Text;
            string lName = LastNameTextBox.Text;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;
            

            p.first_name = fName;
            p.last_name = lName;
            p.phone = phone;
            p.address = address;
          

            db.passenger.AddOrUpdate(p);

            db.SaveChanges();

            this.Close();
        }

      
    }
}
