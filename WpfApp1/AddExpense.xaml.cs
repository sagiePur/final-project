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
    /// Interaction logic for AddExpense.xaml
    /// </summary>
    public partial class AddExpense : Window
    {
        dbEntities2 db = new dbEntities2();

        public AddExpense()
        {
            InitializeComponent();
            EmployeeIdComboBox.ItemsSource = db.employee.ToList();
            EmployeeIdComboBox.DisplayMemberPath = "name";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int employeeId = ((employee)EmployeeIdComboBox.SelectedItem).Id;
            DateTime date = (DateTime)dateP.SelectedDate;
            //DateTime date = dateP.DisplayDate;
            float cost = (float.Parse(CostTextBox.Text));
            string description = DescriptionTextBox.Text;

            expense o = new expense();
            o.employee_id = employeeId;
            o.date = date;
            o.cost = cost;
            o.description = description;

            db.expense.Add(o);

            db.SaveChanges();

            this.Close();
        }
    }
}
