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
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    public partial class AddCustomer : Window
    {
        dbEntities2 db = new dbEntities2();
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string fName = FirstNameTextBox.Text;
            string lName = LastNameTextBox.Text;
            string phone = PhoneTextBox.Text;
            string address = AddressTextBox.Text;
            string email = EmailTextBox.Text;

            customer o = new customer(); //יצירת אובייקט עובד חדש
            o.first_name = fName;
            o.last_name = lName;
            o.phone = phone;
            o.address = address;
            o.email = email;

            db.customer.Add(o);
          
            db.SaveChanges();

            this.Close();
        }
    }
}
