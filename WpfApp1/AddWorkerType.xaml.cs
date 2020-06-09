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
    /// Interaction logic for AddWorkerType.xaml
    /// </summary>
    public partial class AddWorkerType : Window
    {
        dbEntities2 db = new dbEntities2();

        public AddWorkerType()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string title = TitleTextBox.Text;
            float salary = float.Parse(SalaryTextBox.Text);
            string type = LicenseTypeComboBox.Text;
            string description = DescriptionTextBox.Text;

            employee_type t = new employee_type();
            t.title = title;
            t.salery = salary;
            t.license_type = type;
            t.description = description;

            db.employee_type.Add(t);
            db.SaveChanges();

            Close();
        }
    }
}
