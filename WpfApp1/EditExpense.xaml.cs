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
    /// Interaction logic for AddExpense.xaml
    /// </summary>
    public partial class EditExpense : Window
    {
        expense e;

        dbEntities2 db = new dbEntities2();

        public EditExpense(expense o)
        {
            InitializeComponent();
            EmployeeIdComboBox.ItemsSource = db.employee.ToList();
            EmployeeIdComboBox.DisplayMemberPath = "name";

            e = o;

            EmployeeIdComboBox.SelectedValue = db.employee.ToList().First(d => d.Id == e.employee_id);
            dateP.SelectedDate = e.date;
            CostTextBox.Text = e.cost.ToString();
            DescriptionTextBox.Text = e.description;
        }

        private void Button_Click(object sender, RoutedEventArgs ea)
        {
            int employeeId = ((employee)EmployeeIdComboBox.SelectedItem).Id;
            DateTime date = (DateTime)dateP.SelectedDate;
            float cost = (float.Parse(CostTextBox.Text));
            string description = DescriptionTextBox.Text;

            e.employee_id = employeeId;
            e.date = date;
            e.cost = cost;
            e.description = description;

            db.expense.AddOrUpdate(this.e);

            db.SaveChanges();

            this.Close();
        }
    }
}
