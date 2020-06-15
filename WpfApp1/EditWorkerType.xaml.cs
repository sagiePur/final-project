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
    /// Interaction logic for AddWorkerType.xaml
    /// </summary>
    public partial class EditWorkerType : Window
    {
        dbEntities2 db = new dbEntities2();

        employee_type e;

        public EditWorkerType(employee_type o)
        {
            InitializeComponent(); 

            e = o;

            TitleTextBox.Text = e.title;
            SalaryTextBox.Text = e.salery.ToString();
            LicenseTypeComboBox.Text = e.license_type;
            DescriptionTextBox.Text = e.description;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleTextBox.Text;
            float salary = float.Parse(SalaryTextBox.Text);
            string type = LicenseTypeComboBox.Text;
            string description = DescriptionTextBox.Text;

            this.e.title = title;
            this.e.salery = salary;
            this.e.license_type = type;
            this.e.description = description;

            db.employee_type.AddOrUpdate(this.e);
            db.SaveChanges();

            Close();
        }
    }
}
