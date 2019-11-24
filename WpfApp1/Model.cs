using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Model
    {
        dbEntities db = new dbEntities();

        public List<Employees> GetEmployees()
        {
            return db.Employees.ToList();
        }
    }
}
