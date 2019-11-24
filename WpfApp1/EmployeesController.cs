using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class EmployeesController
    {
        Model model = new Model();

        public List<Employees> GetEmployees()
        {
            return model.GetEmployees();
        }
    }
}
