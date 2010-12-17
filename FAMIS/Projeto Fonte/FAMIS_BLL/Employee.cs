using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient; 
using FAMIS_BLL;
using Model;

namespace FAMIS_BLL
{
    public class Employee
    {
        private FAMIS_DALL.Employee _Employee;

        public Employee()
        {
            if (_Employee == null)
            {
                _Employee = new FAMIS_DALL.Employee();
            }
        }

        public Int32 Add(Model.Employee Employee)
        {
            Employee.Amount1 = (Decimal)0.00;
            Employee.Amount2 = (Decimal)0.00;
            Employee.Date1 = DateTime.Now;
            Employee.Date2 = DateTime.Now;
            Employee.Employee_id = _Employee.Add(Employee);
            return Employee.Employee_id; 
        }

        public string Update(Model.Employee Employee)
        {
            return _Employee.Update(Employee);  
        }

        public string Remove(Model.Employee Employee)
        {
            return _Employee.Delete(Employee);
        }

        public Model.Employee Select(Model.Employee Employee)
        {
            return _Employee.Select(Employee);
        }

        public List<Model.Employee> Select(string pQuery)
        {
            return _Employee.Select(pQuery);
        }

        public DataView GetSelect(string pQuery)
        {
            return _Employee.GetSelect(pQuery);
        }

    }
}
