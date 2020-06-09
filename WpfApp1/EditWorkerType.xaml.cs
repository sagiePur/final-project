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

        employee_type o;

        public EditWorkerType(employee_type t)
        {
            InitializeComponent();

            o = t;

            TitleTextBox.Text = t.title;
            SalaryTextBox.Text = t.salery.ToString();
            LicenseTypeComboBox.Text = t.license_type;
            DescriptionTextBox.Text = t.description;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleTextBox.Text;
            float salary = float.Parse(SalaryTextBox.Text);
            string type = LicenseTypeComboBox.Text;
            string description = DescriptionTextBox.Text;

            o.title = title;
            o.salery = salary;
            o.license_type = type;
            o.description = description;

            db.employee_type.AddOrUpdate(o);
            db.SaveChanges();

            Close();
        }
    }
}
