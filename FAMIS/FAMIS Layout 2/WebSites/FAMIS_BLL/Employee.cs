using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient; 
using FAMIS_BLL;

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

        public string Add(Model.Employee Employee)
        {
            return _Employee.Add(Employee);
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


    }
}
