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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class EditCustomer : Window
    {
        dbEntities2 db = new dbEntities2();

        customer c;

        public EditCustomer(customer o)
        {
            InitializeComponent();

            c = o;

            FirstNameTextBox.Text = c.first_name;
            LastNameTextBox.Text = c.last_name;
            PhoneTextBox.Text = c.phone;
            AddressTextBox.Text = c.address;
            EmailTextBox.Text = c.email;
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fName = FirstNameTextBox.Text;
            string lName = LastNameTextBox.Text;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;
            string email = EmailTextBox.Text;

            c.first_name = fName;
            c.last_name = lName;
            c.phone = phone;
            c.address = address;
            c.email = email;

            db.customer.AddOrUpdate(c);

            db.SaveChanges();

            this.Close();
        }
    }
}
